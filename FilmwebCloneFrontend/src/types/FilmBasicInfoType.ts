import type { FilmGenreType } from "./FilmGenreType"

export type FilmBasicInfoType = {
    id: number
    title: string
    subtitle?: string
    releaseDate: Date
    duration: Date
    posterPath: string
    genre: FilmGenreType
    reviewsCount: number
    averageRating: number
}