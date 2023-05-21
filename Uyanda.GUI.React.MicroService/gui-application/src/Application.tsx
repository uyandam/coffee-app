import { BrowserRouter, Route, Routes } from "react-router-dom"
import HomePage from "./pages/Home";
import AboutPage from "./pages/About";


export interface IApplicationProps {}

const Application = (props: IApplicationProps): JSX.Element => {
    return( 
    <BrowserRouter>
        <Routes>
            <Route path='/' element={<HomePage/>}/>
            <Route path='about' element={<AboutPage/>}/>
        </Routes>
    </BrowserRouter>
    );
}
 export default Application;