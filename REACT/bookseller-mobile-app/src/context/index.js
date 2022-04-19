import React, {useContext, useReducer,createContext} from "react"

const BooksellerContext = createContext();

initialState = {
    books:[],
    carts: [],
}
const reducer = (state, action)=>{
    switch(action.type){
        case "FETCH_BOOKS":
        return {...state,books:action.payload}
        case "FETCH_CARTS":
        return {...state,books:action.payload}
        default:
            return state
    }
}
const BooksellerProvider = (props) => {
    const [state,dispatch] = useReducer(reducer,initialState)
    return(
        <BooksellerContext.Provider value={[state,dispatch]}>
            {props.children}
        </BooksellerContext.Provider>
    )
}

export{BooksellerContext,BooksellerProvider,useContext}

