import React, {FC} from "react";
import { BrowserRouter, Route, Routes } from "react-router-dom";
import { deflate } from "zlib";
import AboutPage from "../about";
import HomePage from "../home";
// import 'bootstrap/dist/css/bootstrap.min.css';


interface DirectoryProp {
    home: string
    cart: string
}

// const HeaderComponent: FC <DirectoryProp> = () => {
//     return (
//         <>
//             <h1>
//                 blame it on my ADD baby
//             </h1>
//         </>
//     )
// }

const links = [
    {name:"Home", to:"/"},
    {name:"About", to:"/about"},
    {name:""}
]

const HeaderComponent = () =>  {
    // brand: { name: "NavbarScroller", to: "/" },
    return(
        <>
           <BrowserRouter>
                <Routes>
                    <Route path='/' element={<HomePage/>}/>
                    <Route path='about' element={<AboutPage/>}/>
                </Routes>
            </BrowserRouter> 
        </>
    );
    
}


export default HeaderComponent;