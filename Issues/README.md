# Problemas Comunes

Esta carpeta contiene todos los problemas comunes que se pueden insertar en documentos de Word a través del complemento.

## Estructura de Archivos

Cada problema común debe estar en un archivo markdown (.md) con el frontmatter adecuado. Los problemas están organizados en subcarpetas por categoría.

## Formato de Problemas

Los problemas comunes pueden definir código JavaScript en el frontmatter que se utiliza para generar automáticamente el problema a partir de la salida de herramientas. Las funciones que se pueden definir son:

```typescript
type IssueContext = any;

/* 
  Un método opcional que devuelve un objeto para pasar a 
  getAffectedSystems y getPlaceholderContent para reducir 
  la duplicación de código. 
*/
function getIssueContext(): IssueContext;

/* 
  Un método requerido que devuelve un array de strings de los hosts afectados 
  por el problema. 
*/
function getAffectedSystems(issueContext: IssueContext): string[];

/* 
  Una función opcional que devuelve un string usado para completar un marcador 
  denotado por "{==PLACEHOLDER==}" en el markdown del problema común. 
*/
function getPlaceholderContent(issueContext: IssueContext): string;
```

## Edición de Problemas

Para editar un problema existente o crear uno nuevo, siga estos pasos:

1. Cree una nueva rama desde master
2. Realice sus cambios en el archivo markdown correspondiente
3. Envíe un merge request para revisión

Los cambios aceptados en la rama master se reflejarán automáticamente en el complemento de Word.
