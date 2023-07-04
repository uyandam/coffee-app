import axios from "axios";
import { useState } from "react";


// const client = axios.create({
//     baseURL: "https://localhost:7009/api/Gateway/" 
//   });

// const MenuService = () => {
//     const [title, setTitle] = useState('');
//     const [body, setBody] = useState('');
//     const [posts, setPosts] = useState([]);
// }

//interface for the Helper
interface Params {
headers : any
method: string
}

const postConfig: Params = {
headers: {
          "Authorization": ""
      },
method: 'post'
}

//helper function to be exported
export  const getMenu = async (): Promise<any> =>{
  return await axios({
      ...postConfig,
      url: "https://localhost:7009/api/Gateway/menu"
  }).then ( (response) => {
      console.log(response)
      return {
          status: response.status,
          data: response.data
      }
  }).catch((error) =>{
      console.log(error)
      return {
          status: error.status,
          data: error.response
      }
  })
}
