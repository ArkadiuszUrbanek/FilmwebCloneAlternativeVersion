import type { GenderType } from "./GenderType"
import type { PersonNationalityType } from "./PersonNationalityType"

export type PersonDetailedInfoType = {
    id: number
    firstName: string
    lastName: string
    gender: GenderType
    nationality: PersonNationalityType
    height: number
    birthDate: Date
    description: string
    picturePath: string
}