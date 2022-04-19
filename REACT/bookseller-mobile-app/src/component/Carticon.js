import { TouchablOpacity } from "react-native";
import react from "react";
import { Icon } from "@expo/vector-icons/Ionicons";
import { useNavigation } from "@react-navigation/native";

export default function CartIcon(){
    const navigation = useNavigation()

    return(
        <TouchablOpacity
        onPress={()=> navigation.navigate("Cart")}
        style = {{marginRight : 10}}>
            <Icon name="ios-cart" size = {25} color ="black"/>
        </TouchablOpacity>
    )
}