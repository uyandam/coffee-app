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

export interface Price {
    id: number;
    currency: string;
    price: number
}

export interface Beverage {
    id: number;
    beverageNameId: number;
    beverageName: BeverageName;
    beverageTypeId: number;
    beverageType: BeverageType;
    beverageSizeId: number;
    beverageSize: BeverageSize;
    price: Price;
    count: number;
}
