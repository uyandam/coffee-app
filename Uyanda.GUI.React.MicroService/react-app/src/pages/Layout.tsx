import { Outlet, Link } from "react-router-dom";


function Layout () {
    return(
        <>
            <h1>layout</h1>
            <nav>
                <ul>
                    <li>
                        <Link to="/">Home</Link>
                    </li>
                </ul>
            </nav>
            <Outlet/>
        </>
    )
}

export default Layout;