

export interface BeverageName {
    id: number;
    name: string;
}

export interface BeverageType {
    id: number;
    name: string;
}

export interface BeverageSize {
    id: number;
    name: string;
}

export interface Menu {
    id: number;
    beverageNameId: number;

    beverageName: BeverageName;
    beverageTypeId: number;
    beverageType: BeverageType;
    beverageSizeId: number;
    beverageSize: BeverageSize;
    price: number;
    count: number;
}


