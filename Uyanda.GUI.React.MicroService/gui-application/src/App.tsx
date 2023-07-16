import 'bootstrap/dist/css/bootstrap.min.css';  
import { Routes, Route } from 'react-router-dom';
import Navigate from './pages/navigation/navigate';
import Menu from './pages/menu';
import Cart from './pages/cart';
import Checkout from './pages/checkout';
import HomePage from './pages/home';



const App = () => {
  return (
     <>
        <Navigate />
        <Routes>
            <Route path="/" element={<HomePage/>}/>
           <Route path="/menu" element={<Menu />} />
           <Route path="/cart" element={<Cart />} />
           <Route path="/checkout" element={<Checkout />} />
        </Routes>
     </>
  );
 };

// function App() {  
//   return (  
//     <>  
//       <Navbar collapseOnSelect expand="lg" bg="dark" variant="dark">  
//         <Container>  
//           <Navbar.Brand href="#home">Navbar Brand</Navbar.Brand>  
//           <Navbar.Toggle aria-controls="responsive-navbar-nav" />  
//           <Navbar.Collapse id="responsive-navbar-nav">  
//             <Nav className="me-auto">  
//               <Nav.Link href="#features">Link 1</Nav.Link>  
//               <Nav.Link href="#pricing">Link 2</Nav.Link>  
//               <NavDropdown title="Dropdown" id="collasible-nav-dropdown">  
//                 <NavDropdown.Item href="#action/3.1">Item 1</NavDropdown.Item>  
//                 <NavDropdown.Item href="#action/3.2">Item 2</NavDropdown.Item>  
//                 <NavDropdown.Item href="#action/3.3">Item 3</NavDropdown.Item>  
//                 <NavDropdown.Divider />  
//                 <NavDropdown.Item href="#action/3.4">Separated Item</NavDropdown.Item>  
//               </NavDropdown>  
//             </Nav>  
//             <Nav>  
//               <Nav.Link href="#deets">Another Link</Nav.Link>  
//               <Nav.Link eventKey={2} href="#memes">  
//                 Another Link  
//               </Nav.Link>  
//             </Nav>  
//           </Navbar.Collapse>  
//         </Container>  
//       </Navbar>  
//     </>  
//   );  
// }  
export default App;  