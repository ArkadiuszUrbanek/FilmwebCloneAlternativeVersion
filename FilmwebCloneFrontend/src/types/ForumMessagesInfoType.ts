import type { GenderType } from "./GenderType"

export type ForumMessagesInfoType = {
    forumName: string
    messages: {
        id: number
        text: string
        creationDate: Date
        author: {
            id: number
            firstName: string
            lastName: string
            gender: GenderType
        }
    }[]
}