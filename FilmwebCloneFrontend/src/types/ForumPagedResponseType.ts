export type ForumPagedResponseType = {
    pagesCount: number
    resultsCount: number
    currentPageResultsCount: number
    forums: {
        id: number
        name: string
        creationDate: Date
        messagesCount: number
        author: {
            id: number
            firstName: string
            lastName: string
        }  
    }[]
}