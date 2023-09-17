
import getMenu from "../services/beverage.service";

function Home() {

    console.log(getMenu().then(value => {
        console.log('resolved', value);
      }));

      console.log(getMenu().catch(error => {
        console.log('rejected', error);
      }));

    return (<>
        <h1>Home page</h1>
    </>)
}

export default Home;