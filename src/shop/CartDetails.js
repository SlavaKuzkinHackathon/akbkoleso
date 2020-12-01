import React, { Component } from "react";
import { Link } from "react-router-dom";
import { CartDetailsRows } from "./CartDetailsRows";
export class CartDetails extends Component {
    getLinkClasses = () => `btn btn-secondary m-1
 ${this.props.cartItems === 0 ? "disabled" : ""}`;
    render() {
        return <div className="m-3">
            <h2 className="text-center">Моя корзина</h2>
            <table className="table table-bordered table-striped">
                <thead>
                    <tr>
                        <th>Количество</th>
                        <th>Наименование</th>
                        <th className="text-right">Цена</th>
                        <th className="text-right">Итого</th>
                        <th />
                    </tr>
                </thead>
                <tbody>
                    <CartDetailsRows cart={this.props.cart}
                        cartPrice={this.props.cartPrice}
                        updateQuantity={this.props.updateCartQuantity}
                        removeFromCart={this.props.removeFromCart} />
                </tbody>
            </table>
            <div className="text-center">
                <Link className="btn btn-primary m-1" to="/shop">
                    Вернуться к покупкам
                </Link>
                <Link className={this.getLinkClasses()} to="/shop/checkout">
                    Оформить заказ
                 </Link>
            </div>
        </div>
    }
}