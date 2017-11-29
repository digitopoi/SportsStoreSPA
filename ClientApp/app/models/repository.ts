import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

import { Product } from './product.model';

@Injectable()
export class Repository {

    product: Product;

    constructor(private http: Http) {
        this.getProduct(1);
    }

    getProduct(id: number) {
        this.http.get('/api/products/' + id)
            .subscribe(response => this.product = response.json());
    }
}

