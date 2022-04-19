import React from "react";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import Header from "./components/header/index";
import BookCreate from "./pages/BookCreate";
import Books from "./pages/Books";
import Cart from "./pages/Cart";
import BookEdit from "./pages/BookEdit";
import NotFound from "./pages/NotFound";
import "./App.css";

function App() {
  return (
    <BrowserRouter>
      <div className="ms-Grid" dir="ltr">
        <div className="ms-Grid-row">
          <div className="ms-Grid-col ms-sm-1 mx-xl1">
            <Header />
          </div>
        </div>
      </div>
      <div style={{ paddingTop: 50 }}>
        <Routes>
          <Route path="*" element={<NotFound />}></Route>
          <Route path="/" element={<Books />}></Route>
          <Route path="/books" element={<Books />}></Route>
          <Route path="/cart" element={<Cart />}></Route>
          <Route path="/books/create" element={<BookCreate />}></Route>
          <Route path="/books/edit/:id" element={<BookEdit />}></Route>
        </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
