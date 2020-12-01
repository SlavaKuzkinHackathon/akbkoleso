import React, { Component } from "react";
import { Link } from "react-router-dom";
import { PaginationControls } from "../PaginationControls";
import { ProductsRow } from "./ProductsRow";
export class ProductsTable extends Component {
    render = () =>
        <div>
            <h4 className="bg-info text-white text-center p-2">
                {this.props.totalSize} Товар
 </h4>
            <PaginationControls keys={["ID", "Name", "Category"]}
                {...this.props} />
            <table className="table table-sm table-striped">
                <thead>
                    <tr><th>ID</th>
                        <th>Наименование</th><th>Категория</th>
                        <th className="text-right">Цена</th>
                        <th className="text-center"></th>
                    </tr>
                </thead>
                <tbody>
                    {this.props.products.map(prod =>
                        <ProductsRow key={prod.id} product={prod}
                            deleteProduct={this.props.deleteProduct} />
                    )}
                </tbody>
            </table>
            <div className="text-center">
                <Link to="/admin/products/create" className="btn btn-primary">
                    Создать карточку товара
                 </Link>
            </div>
        </div>
}