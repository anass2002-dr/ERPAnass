import { Familly } from "../Familly/Familly";

export class Article {
  idArticle?: Number = 0;
  articleRef?: string = "";
  articleName?: string = "";
  descriptionArticle?: string = "";
  purchasePrice?: Number = 0;
  sellingPrice?: Number = 0;
  familyID?: Number = 0;
  familly?: Familly = new Familly();
  stockQuantity?: number = 0;
}

