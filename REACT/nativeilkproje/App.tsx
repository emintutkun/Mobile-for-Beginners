import { StatusBar } from 'expo-status-bar';
import {
  StyleSheet,
  Text,
  View,
  Image,
  SafeAreaView,
  ScrollView,
  Button,
  TextInput,
  FlatList
} from 'react-native';

const data = [
  {
    "id": 1,
    "name": "The Book Thief",
    "author": "Markus Zusak",
    "imgUrl": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1522157426l/19063._SY475_.jpg",
    "about": "Elit mollit in enim qui. Est ea anim voluptate mollit magna. Tempor aliqua esse nulla reprehenderit reprehenderit quis voluptate velit. Aute id reprehenderit deserunt incididunt laboris et pariatur nulla. Excepteur velit qui ullamco aute laboris eu aliqua in nostrud anim reprehenderit deserunt occaecat. Fugiat sit est magna aliqua. Nisi non incididunt sunt fugiat nostrud aliqua nostrud excepteur ullamco sit excepteur commodo enim voluptate."
  },
  {
    "id": 2,
    "name": "Sapiens",
    "author": "Yuval Noah Harari",
    "imgUrl": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1420585954l/23692271.jpg",
    "about": "Nulla enim cillum deserunt proident eiusmod deserunt excepteur magna voluptate duis. Exercitation ex magna excepteur est id reprehenderit officia amet. Adipisicing quis anim ad sit commodo pariatur exercitation eiusmod commodo velit. Deserunt commodo pariatur quis magna. Fugiat enim tempor aliqua esse ut irure nostrud eiusmod do consectetur laborum."
  },
  {
    "id": 3,
    "name": "Crime and Punishment",
    "author": "Fyodor Dostoyevsky",
    "imgUrl": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1382846449l/7144.jpg",
    "about": "Velit voluptate et nostrud eu tempor excepteur aliqua laborum veniam sit. Reprehenderit occaecat ex fugiat veniam commodo. Laboris ut minim quis anim reprehenderit dolor. Fugiat laborum cillum sunt reprehenderit anim anim et ut Lorem sit ipsum magna non. Excepteur officia proident incididunt esse. Cillum laboris nulla ea minim officia amet deserunt consectetur velit aliqua est incididunt enim proident. Ea ut laborum aute sunt enim velit."
  },
  {
    "id": 4,
    "name": "No Longer Human",
    "author": "Osamu Dazai",
    "imgUrl": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1422638843l/194746.jpg",
    "about": "Velit Lorem nulla ad enim laborum non exercitation sint nostrud reprehenderit minim occaecat officia. Minim est Lorem minim fugiat sit proident quis pariatur incididunt qui consequat. Laborum aliqua esse nostrud incididunt reprehenderit aliqua nisi."
  },
  {
    "id": 5,
    "name": "Atomic Habits",
    "author": "James Clear",
    "imgUrl": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1535115320l/40121378._SY475_.jpg",
    "about": "Sint ut amet occaecat sunt in consectetur aliquip cupidatat aliqua consectetur incididunt magna dolore. Laborum incididunt mollit quis qui ut veniam quis in incididunt ut qui aliqua est. Amet proident magna duis velit non minim ipsum mollit laborum deserunt sit. Ea veniam ea aliqua incididunt aute laborum nisi tempor dolore. Cillum eiusmod officia nostrud qui cillum esse excepteur in exercitation ex laborum ipsum occaecat sint."
  },
  {
    "id": 7,
    "name": "Dune",
    "author": "Frank Herbert",
    "imgUrl": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1434908555l/234225._SY475_.jpg",
    "about": "Occaecat qui aliquip sit labore non aliquip velit sunt qui minim excepteur adipisicing sit. Do eu laborum nostrud aliquip nisi in minim ut adipisicing incididunt dolor pariatur cillum. Dolore occaecat dolor veniam id fugiat anim et cillum pariatur magna incididunt deserunt. Commodo pariatur esse et pariatur in enim minim nostrud duis et dolor nulla Lorem ipsum. Nulla qui ad commodo voluptate culpa incididunt proident pariatur nisi ad dolore Lorem. Cillum aliquip veniam irure ad. Excepteur pariatur enim in sit."
  },
  {
    "id": 8,
    "name": "Atlas Shrugged",
    "author": "Ayn Rand",
    "imgUrl": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1405868167l/662.jpg",
    "address": "227 Gotham Avenue, Bethany, Illinois, 672",
    "about": "Exercitation voluptate do excepteur cupidatat commodo velit qui amet aute dolore quis et laboris est. Aute eiusmod fugiat aliqua dolor commodo et. Irure cillum reprehenderit consectetur in incididunt enim cupidatat sit elit magna. Dolor in aliqua minim eu officia tempor amet duis. Commodo magna ex velit deserunt adipisicing nulla pariatur anim consequat velit cillum. Mollit nisi nostrud Lorem deserunt ea. Occaecat et tempor ea ea ipsum sunt deserunt ea duis sit sunt in."
  }
]

export default function App() {

  function onChangeText(text) {
    console.log("Text: ", text);
  }
  return (
    <SafeAreaView style={StyleSheet.container}>
      <ScrollView>
        {data.map((item, index) => (
          <View styles={styles.item} key={index}>
            <Image
              source={{ uri: item.imgUrl }}
              style={{ width: 395, height: 600 }} />
            <Text style={styles.title}>{item.name}</Text>
            <Button
              title="Add to Cart"
              style= {{width:200,height:50}}
              onPress={() => console.log("Button clicked", item)} />
          </View>
        ))}
      </ScrollView>
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    flexDirection: "row",
    backgroundColor: 'yellow',
    alignItems: 'flex-start',
    justifyContent: 'flex-start',
  },
  title:{

  },
  item:{

  },
});
