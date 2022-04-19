import React from "react";
import { Link } from "react-router-dom";
import { Layer, getTheme, fontIcon, FontIcon } from "@fluentui/react";
import "./header.css";

const theme = getTheme();

export default function Header() {
    const contentStyle = {
        backgroundColor: theme.palette.themePrimary,
        color: theme.palette.white,
        lineHeight: "50px"
    }
    const content = (
        <div style={contentStyle}>
            <div className="ms-Grid" dir="ltr">
                <div className="ms-Grid-row"
                    style={{
                        paddingLeft: 32,
                        paddingRight: 20
                    }}>
                    <Link to="/"
                        style={{
                            textDecoration: "none"
                        }}
                        className="header-text">KİTAP EVİ</Link>
                    <Link to="/cart"
                        className="header-button">
                        <FontIcon iconName="ShoppingCart" />
                    </Link>
                </div>
            </div>
        </div>
    )

    return (
        <Layer>
            {content}
        </Layer>
    )
}