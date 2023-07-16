import { getMenu } from "../services/menu.service";


const Menu = () => {

    const menuItems = () => getMenu().then(
        (res) => {
            if(res.status === 200) {
                console.log(res);
                // console.log(res.result);
            } else {
                console.log(res);
                
            }
        }
    )

    menuItems();

    

    return(
        <>
            <div>
                <p>Menu page</p>
            </div>
        </>
    )
}


export default Menu;