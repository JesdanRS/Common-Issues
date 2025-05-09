#! /usr/bin/env python3

import argparse
import logging
import sys
import os
import re
import requests

def findLinks(filename):
    """Find all the links in a file, removing example links"""

    # URLs that we don't care about testing
    blacklist = ["https://www.example.org/"]

    with open(filename, "r") as f:
        text = f.read()
        urls = re.findall("(?<!{==)https?://(?![^/?]*example\.com|.*{==)[^\s\]\/]*\.[^\s\]]*(?<![=}'\"])", text)
        ret = []
        for u in urls:
            if u not in blacklist:
                ret.append(u)
                
        return ret

def checkURL(url, f, out):
    """Check a URL too see if it 404s"""
    headers = { 'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:82.0) Gecko/20100101 Firefox/82.0' }
    r = requests.get(url, allow_redirects=True, headers=headers)

    if not r.ok:
        out.info("BROKEN: {} ({}, status: {})".format(u, f, r.status_code))

    # Warn of redirects
    if not args.allow_redirects and len(r.history) > 0:
        out.info("REDIRECT: {} ({}, status: {})".format(u, f, r.status_code))

    # Plain text
    if not url.startswith("https://"):
        out.info("HTTP: {} ({}, status: {})".format(u, f, r.status_code))

if __name__ == "__main__":
    parser = argparse.ArgumentParser()
    parser.add_argument("dir", help="The directory of the common issues")
    parser.add_argument("-v", "--verbose", help="Use verbose mode", action="store_true")
    parser.add_argument("-r", "--allow-redirects", help="Don't warn about URLs that redirect", action="store_true")
    args = parser.parse_args()

    # Logging
    logger = logging.getLogger("{} stder".format(__name__))
    logger.addHandler(logging.StreamHandler(sys.stderr))
    if args.verbose:
        logger.setLevel(logging.DEBUG)
    else:
        logger.setLevel(logging.INFO)

    # Output
    output = logging.getLogger("{} stdout".format(__name__))
    output.addHandler(logging.StreamHandler(sys.stdout))
    output.setLevel(logging.INFO)

    # Get URLs
    base_dir = os.path.abspath(args.dir)
    logger.info("Searching for links in {}".format(base_dir))
    urls = []
    for root, dirs, files in os.walk(base_dir):
        # Ignore hidden files
        bad_files = ["README.md"]
        files = [f for f in files if not f[0] == '.' and f not in bad_files]
        dirs[:] = [d for d in dirs if not d[0] == '.']

        for f in files:
            full_path = os.path.join(root, f)
            logger.debug("Checking {}".format(full_path))
            file_urls = findLinks(full_path)
            for u in file_urls:
                logger.debug("Found URL {}".format(u))

            urls.extend([(u,full_path) for u in file_urls])

    # Check URLs
    logger.info("Broken URLs:")
    for u, f in urls:
        logger.debug("Checking URL {} from file {}".format(u, f))
        try:
            checkURL(u, f, output)
        except Exception as e:
            logger.error("ERROR: Failed to fetch URL {}: {}".format(u, e))
