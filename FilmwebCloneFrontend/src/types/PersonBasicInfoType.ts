import type { PersonPositionType } from "./PersonPositionType"

export type PersonBasicInfoType = {
    id: number,
    firstName: string,
    lastName: string,
    picturePath: string,
    positions: PersonPositionType[]
}