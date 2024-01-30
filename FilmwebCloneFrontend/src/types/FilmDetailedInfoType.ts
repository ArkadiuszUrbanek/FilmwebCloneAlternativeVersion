import type { FilmGenreType } from "./FilmGenreType"

export type FilmDetailedInfoType = {
    id: number
    title: string
    subtitle?: string
    description: string
    releaseDate: Date
    duration: Date
    posterPath: string
    bannerPath: string
    genre: FilmGenreType
    reviewsCount: number
    averageRating: number
}