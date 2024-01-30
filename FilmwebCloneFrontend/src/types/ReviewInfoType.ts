import type { ReviewAuthorInfoType } from "./ReviewAuthorInfoType"

export type ReviewInfoType = {
    id: number
    rating: number
    title: string
    description: string
    creationDate: Date
    author: ReviewAuthorInfoType
}
