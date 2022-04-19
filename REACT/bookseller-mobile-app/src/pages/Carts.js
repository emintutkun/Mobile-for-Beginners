import{
    View,
    Text,
    StyleSheet,
    FlatList,
    Image,
    TouchablOpacity
} from "react-native"
import React, {useEffect} from "react"
import Sepetaror from "../component/Seperator"
import axios from "axios"
import { BooksellerContext, useContext } from "../context"