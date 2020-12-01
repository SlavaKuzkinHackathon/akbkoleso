import React, { Component } from "react";
export class ValidationError extends Component {
    render() {
        if (this.props.errors) {
            return this.props.errors.map(err =>
                <h8 className="text-danger" key={err}>
                    {err}
                </h8>
            )
        }
        return null;
    }
}