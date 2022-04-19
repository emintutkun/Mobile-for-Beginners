import React from "react";
import { CommandBar } from "@fluentui/react";
import { useNavigate } from "react-router-dom";


export default function Toolbar() {

    const navigate = useNavigate();
    return (
        <div>
            <CommandBar
                items={
                    [{
                        key: "add",
                        text: "Create",
                        iconProps: { iconName: "Add" },
                        onClick: () => navigate("/books/create")

                    }
                    ]
                }
            />
            <hr style={{
                border: "1px solid #eee", margin: 0
            }} />
        </div>
    );
};

// C:\'Program Files (x86)'\Yarn\bin\yarn start
