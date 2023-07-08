export interface ContactDetails {
    id: number;
    emailAddress: string | null;
    phoneNumber: string | null;
}

export interface CustomerStatus {
    id: number;
    customerId: number;
    isFound: boolean;
}

export interface Customer {
    id: number;
    name: string | null;
    surname: string | null;
    points: number;
    contactDetailsId: number;
    contactDetails: ContactDetails | null;
    CustomerStatusId: number;
    customerStatus: CustomerStatus | null;
}