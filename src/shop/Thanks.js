import React, { Component } from "react";
import { Link } from "react-router-dom";
export class Thanks extends Component {
    render() {
        return <div>
            <div className="col bg-dark text-white">
                <div className="navbar-brand">АвтоградШина</div>
            </div>
            <div className="m-2 text-center">
                <h2>Спасибо</h2>
                <p>Благодорим за размещения заказа.</p>
                <p>Ваш номер заказа #{this.props.order ? this.props.order.id : 0}</p>
                <p>Мы отправим ваш товар как можно скорее.</p>
                <Link to="/shop" className="btn btn-primary">
                    Вернуться в магазин
                </Link>
            </div>
        </div>
    }
}