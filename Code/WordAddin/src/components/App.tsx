import * as React from 'react';
import { Pivot, PivotItem, IconButton, CommandBarButton, FontClassNames, css, SearchBox, List } from 'office-ui-fabric-react';
import Progress from './Progress';
import { GroupedList, IGroup, IGroupDividerProps } from 'office-ui-fabric-react/lib/components/GroupedList/index';
import { SelectionMode } from 'office-ui-fabric-react/lib/utilities/selection/index';

import CommonIssues from '../../../../CommonIssues.json';

enum Risk {
    Informational = 1,
    Low = 2,
    Medium = 3,
    High = 4,
    Critical = 5
}


export interface AppProps {
    title: string;
    isOfficeInitialized: boolean;
}

export interface AppState {
    _filteredItems: any[];
    _items: any[];
    _groups: IGroup[];
}

export default class App extends React.Component<AppProps, AppState> {
    constructor(props, context) {
        super(props, context);
        this.state = {
            _filteredItems: [],
            _items: [],
            _groups: []
        };
    }

    componentDidMount() {
        this.setState({
            _items: this.createListItems(),
            _groups: this.createGroups()
        });
        this._groupListOnRenderCell = this._groupListOnRenderCell.bind(this);
        this._listOnRenderCell = this._listOnRenderCell.bind(this);
        this._searchOnSearch = this._searchOnSearch.bind(this);
        this._searchOnClear = this._searchOnClear.bind(this);
    }

    insertOoxml = async (ooxml: string) => {
        return Word.run(async context => {
            const originalRange = context.document.getSelection();
            const insertedRange = originalRange.insertOoxml(ooxml, Word.InsertLocation.replace);
            context.load(insertedRange.paragraphs, 'items');
            await context.sync()
                .then(() => {
                    insertedRange.paragraphs.items[0].style = 'Heading 3';
                })
                .then(context.sync);
        });
    }

    render() {
        const {
            title,
            isOfficeInitialized,
        } = this.props;

        if (!isOfficeInitialized) {
            return (
                <Progress
                    title={title}
                    logo='assets/logo-filled.png'
                    message='Please sideload your addin to see app body.'
                />
            );
        }

        return (
            <div>
                <Pivot>
                    <PivotItem linkText='Search Issues'>
                        <SearchBox
                            placeholder='Search'
                            onSearch={this._searchOnSearch}
                            onClear={this._searchOnClear}
                        />
                        <List
                            items={this.state._filteredItems}
                            onRenderCell={this._listOnRenderCell}
                        />
                    </PivotItem>
                    <PivotItem linkText='Browse Issues'>
                        <GroupedList
                            items={this.state._items}
                            onRenderCell={this._groupListOnRenderCell}
                            selectionMode={SelectionMode.none}
                            groups={this.state._groups}
                            groupProps={{
                                onRenderHeader: this._groupListOnRenderHeader,
                            }}
                        />
                    </PivotItem>
                </Pivot>
            </div>
        );
    }

    private createListItems(): any {
        return CommonIssues.map((commonIssue, _index) => {

            return {
                key: commonIssue.Title,
                name: commonIssue.Title,
                flatOpcSingular: commonIssue.FlatOpcSingular,
                flatOpcPlural: commonIssue.FlatOpcPlural,
                risk: commonIssue.Risk,
                impactRisk: commonIssue.ImpactRisk,
                likelihoodRisk: commonIssue.LikelihoodRisk
            };
        });
    }

    private createGroups() {
        let startIndex = 0;
        const categories = [...new Set(CommonIssues.map(x => x.Category))];
        return Array.apply(null, Array(categories.length)).map((_value: number, index: number) => {
            const category = categories[index];
            const items = CommonIssues.filter(x => x.Category === category);
            startIndex += items.length;

            return {
                count: items.length,
                key: category,
                name: category,
                startIndex: startIndex - items.length,
                isCollapsed: true
            };
        });
    }

    private _searchOnSearch(newValue: any) {
        this.setState({
            _filteredItems: (newValue === '') ? [] : this.state._items.filter(item => item.name.toLowerCase().includes(newValue.toLowerCase()))
        });
    }

    private _searchOnClear() {
        this.setState({
            _filteredItems: []
        });
    }

    private _listOnRenderCell(item: any, _index: number, _containsFocus: boolean): JSX.Element {
        return (
            <div className={css(FontClassNames.small)}>
                <CommandBarButton iconProps={{ iconName: 'StepInsert' }} title='Insert (Singular)' onClick={() => this.insertOoxml(item.flatOpcSingular)}/>
                <CommandBarButton iconProps={{ iconName: 'StepSharedInsert' }} title='Insert (Plural)' onClick={() => this.insertOoxml(item.flatOpcPlural)}/>
                {item.name} - {Risk[item.risk]} ({Risk[item.impactRisk].substring(0, 1)}/{Risk[item.likelihoodRisk].substring(0, 1)})
            </div>
        );
    }

    private _groupListOnRenderCell(_nestingDepth: number, item: any, _itemIndex: number): JSX.Element {
        return (
            <div className={css(FontClassNames.small)}>
                <CommandBarButton iconProps={{ iconName: 'StepInsert' }} title='Insert (Singular)' onClick={() => this.insertOoxml(item.flatOpcSingular)}/>
                <CommandBarButton iconProps={{ iconName: 'StepSharedInsert' }} title='Insert (Plural)' onClick={() => this.insertOoxml(item.flatOpcPlural)}/>
                {item.name} - {Risk[item.risk]} ({Risk[item.impactRisk].substring(0, 1)}/{Risk[item.likelihoodRisk].substring(0, 1)})
            </div>
        );
    }

    private _groupListOnRenderHeader(props: IGroupDividerProps): JSX.Element {
        const toggleCollapse = (): void => {
          props.onToggleCollapse!(props.group!);
        };

        return (
          <div className={css('ci-issue-list-group-heading', FontClassNames.mediumPlus)} onClick={toggleCollapse}>
            <IconButton iconProps={{ iconName: props.group!.isCollapsed ? 'ChevronRightSmall' : 'ChevronDownSmall'}} />
            {props.group!.name.replace(/^\d\d_/, '').replace(/_/g, ' ')}
          </div>
        );
      }

}
