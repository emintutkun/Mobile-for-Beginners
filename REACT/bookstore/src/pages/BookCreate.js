import React, { useState } from "react";
import axios from "axios";
import { Stack, PrimaryButton, TextField } from "@fluentui/react";
import ToolBar from "../Toolbar";

export default function BookCreate() {

    const [pageData, setPageData] = useState({
        name: "",
        author: "",
        imgUrl: "",
        about: ""
    })

    const onChangeText = (e) => {
        const { name, value } = e.target

        setPageData({ ...pageData, [name]: value })
    }
    function CreateBook() {
        axios
            .post("http://api-bookseller.herokuapp.com/books", pageData)
            .then((res) => {
                console.log("Response: ", res)
                if (res.status == 201) {
                    alert("Book created successfully")
                }
            })
    }


    return (
        <>
        <ToolBar/>
        <div className="content">
            <div className="content-header">Create Book</div>
            <Stack
                tokens={{ childrenGap: 10 }}
                styles={
                    {
                        root: {
                            width: 700,
                            marginLeft: 10,
                            marginTop: 10
                        }
                    }
                }>

                <TextField
                    label="Name"
                    name="name"
                    value={pageData.name}
                    placeholder={"Please enter the name"}
                    onChange={onChangeText}
                    required
                />
                <TextField
                    label="Author"
                    name="author"
                    value={pageData.author}
                    placeholder={"Please enter the name"}
                    onChange={onChangeText}
                    required
                />
                <TextField
                    label="Image"
                    name="imgUrl"
                    value={pageData.imgUrl}
                    placeholder={"Please enter the name"}
                    onChange={onChangeText}
                    required
                />
                <TextField
                    label="About"
                    name="about"
                    value={pageData.about}
                    placeholder={"Please enter the name"}
                    onChange={onChangeText}
                    required
                />
                <PrimaryButton
                text="Create Book"
                onClick={()=>CreateBook()}
                style={{width:"10%",height:"50px"}}
                onChange={onChangeText}
                />
            </Stack>
        </div>
        </>
    );
}