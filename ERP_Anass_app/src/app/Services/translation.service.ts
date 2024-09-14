import { Injectable } from '@angular/core';
import * as arTranslations from 'src/assets/js/Translate/ar.json'; // Adjust the path as needed
import * as enTranslations from 'src/assets/js/Translate/en.json'; // Adjust the path as needed
import * as frTranslations from 'src/assets/js/Translate/fr.json'; // Adjust the path as needed

@Injectable({
  providedIn: 'root'
})
export class TranslationService {

  // ar: any = arTranslations
  constructor() { }
  translatePage(): void {
    const langue = window.localStorage.getItem('lang')
    var langueTranslate: any = arTranslations
    switch (langue) {
      case 'Fr':
        langueTranslate = frTranslations
        break;
      case 'Ar':
        langueTranslate = arTranslations
        break;
      default:
        break;
    }
    if (langue != 'En') {
      const tags = ['span', 'h1', 'h2', 'h3', 'h4', 'li', 'button']; // List of tags to target

      tags.forEach(tag => {
        // Get all elements for the current tag
        const elements = document.getElementsByTagName(tag);

        // Iterate over each element
        Array.from(elements).forEach((element: Element) => {
          // Cast element to HTMLElement to access innerText
          const htmlElement = element as HTMLElement;

          // Iterate over translation keys
          Object.keys(langueTranslate).forEach(key => {
            // Check if the element's inner text matches the key

            if (htmlElement.innerText.trim().toUpperCase() === key.toUpperCase()) {
              // Replace the inner text with the corresponding Arabic translation
              htmlElement.innerText = langueTranslate[key];
              // console.log(key, htmlElement.innerText);
            }
          });
        });
      });
    }
  }

}
