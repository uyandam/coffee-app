import axios from "axios";
import { useState } from "react";


const client = axios.create({
    baseURL: "https://localhost:7009/api/Gateway/" 
  });

const MenuService = () => {
    const [title, setTitle] = useState('');
    const [body, setBody] = useState('');
    const [posts, setPosts] = useState([]);

    

}