import React, {FC} from "react";
import { deflate } from "zlib";

interface DirectoryProp {
    home: string
    cart: string
}

const HeaderComponent: FC <DirectoryProp> = () => {
    return (
        <>
            <h1>
                blame it on my ADD baby
            </h1>
        </>
    )
}

export default HeaderComponent;