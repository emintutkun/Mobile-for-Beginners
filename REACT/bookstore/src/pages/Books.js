import React from "react";
import { useEffect, useState } from "react";
import axios from "axios";
import { DetailsList, SelectionMode, Stack, PrimaryButton } from "@fluentui/react";
import { useNavigate } from "react-router-dom";
import Toolbar from "../Toolbar";

const columnProps = {
    tokens: { childrenGap: 20 },
    style: { root: { width: 100 } },
}

export default function Books() {
    const [books, setBooks] = useState([]);
    const navigate = useNavigate();
    const columns = [
        {
            key: "id",
            name: "Id",
            fieldName: "id",
            minWidth: 10,
            maxWidth: 50,
            isRowHeader: true
        },
        {
            key: "imgUrl",
            name: "Image",
            fieldName: "imgUrl",
            minWidth: 200,
            maxWidth: 250,
            isRowHeader: true,
            onRender: (item) => (
                <img
                    src={item.imgUrl}
                    style={{ width: "200px", height: "250px" }}
                    alt={`${item.name} - ${item.author}`}/>
            )
        },
        {
            key: "name",
            name: "Name",
            fieldName: "name",
            minWidth: 100,
            maxWidth: 150,
            isRowHeader: true
        },
        {
            key: "author",
            name: "Name",
            fieldName: "author",
            minWidth: 100,
            maxWidth: 200,
            isRowHeader: true
        },
        {
            key: "about",
            name: "About",
            fieldName: "about",
            minWidth: 100,
            maxWidth: 200,
            isRowHeader: true
        },
        {
            key: "process",
            name: "Action",
            fieldName: "Action",
            minWidth: 300,
            maxWidth: 500,
            isRowHeader: true,
            onRender: (item) => (
                <Stack {...columnProps} horizontal>
                    <PrimaryButton
                        text="Add to Cart"
                        onClick={() => AddTocart(item)} />
                    <PrimaryButton
                        text="Edit Book"
                        onClick={() => navigate("/books/edit/" + item.id, { state: { id: item.id } })} />
                    <PrimaryButton
                        text="Delete Book"
                        onClick={async () => await DeleteBook(item.id)} />
                </Stack>
            )
        }
    ]
    function AddTocart(cartItem) {
        axios
            .post("https://api-bookseller.herokuapp.com/carts",cartItem)
            .then((response) => {
                console.log(response.data);
            })
    }
    async function DeleteBook(bookID) {
        await axios
            .delete(`https://api-bookseller.herokuapp.com/books/${bookID}`)
            GetBooks()
    }
    function GetBooks() {
    axios
        .get("https://api-bookseller.herokuapp.com/books")
        .then((response) => {
            setBooks(response.data)
        });
    }

    useEffect(() => {
        GetBooks()
    }, []);

    return (
        <div>
            <Toolbar/>
            <div className="content">
                <div className="content-header">Books</div>
                <DetailsList 
                items={books} 
                columns={columns} 
                SelectionMode={SelectionMode.none}
                />
            </div>
        </div>
    )
}