
export interface BillOfMaterials {
    idBOM?: number;
    parentArticleId?: number;
    childArticleId?: number;
    quantityNeeded?: number;
    parentArticle?: any;
    childArticle?: any;
}
