import type { GenderType } from "./GenderType"
import type { UserRoleType } from "./UserRoleType"

export type LoginInfoType = {
    token?: string,
    sub?: number,
    givenName?: string,
    surname?: string,
    email?: string,
    gender?: GenderType,
    role?: UserRoleType
}