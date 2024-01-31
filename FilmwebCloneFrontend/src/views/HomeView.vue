<template>
    <navbar-component></navbar-component>
    <div class="mt-6 px-10 grid grid-cols-1 sm:grid-cols-1 md:grid-cols-1 lg:grid-cols-1 xl:grid-cols-2 2xl:grid-cols-3 gap-5">
        <div v-for="film in films" :key="film.id" class="w-full lg:max-w-full lg:flex min-h-[300px]">
            <div 
                v-bind:style="{ 'background-image': 'url(' + film.posterPath + ')' }"
                class="h-48 lg:h-auto lg:w-48 flex-none bg-cover rounded-l text-center overflow-hidden relative group"
            > 
                <div class="absolute top-0 left-0 w-full h-0 flex flex-col justify-center items-center bg-black/40 opacity-0 duration-500 group-hover:h-full group-hover:opacity-100">
                    <router-link 
                        v-bind:to="{ name: 'film-details', params: { filmId: film.id }}"
                        class="flex items-center px-3 py-2 rounded-full bg-amber-400 hover:bg-amber-600 duration-300">
                        <svg width="24px" height="24px" viewBox="0 0 32 32" xmlns="http://www.w3.org/2000/svg">
                            <path d="M27 24.57l-5.647-5.648a8.895 8.895 0 0 0 1.522-4.984C22.875 9.01 18.867 5 13.938 5 9.01 5 5 9.01 5 13.938c0 4.929 4.01 8.938 8.938 8.938a8.887 8.887 0 0 0 4.984-1.522L24.568 27 27 24.57zm-13.062-4.445a6.194 6.194 0 0 1-6.188-6.188 6.195 6.195 0 0 1 6.188-6.188 6.195 6.195 0 0 1 6.188 6.188 6.195 6.195 0 0 1-6.188 6.188z"/>
                        </svg>
                        <span class="font-bold">View</span>
                    </router-link>
                </div>
            </div>
            <div class="w-full border-r border-b border-l border-gray-400 lg:border-l-0 lg:border-t lg:border-gray-400 bg-white rounded-b lg:rounded-b-none lg:rounded-r p-4 flex flex-col justify-between leading-normal">
                <div class="mb-8">
                    <p class="text-black font-bold text-xl ">{{ film.title }}</p>
                    <p v-if="film?.subtitle" class="text-black font-medium text-lg">{{ film.subtitle }}</p>
                    <div class="flex">
                        <div class="flex items-center relative">
                            <svg v-for="n in maxStarRating" width="20px" height="20px" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                                <path class="fill-yellow-400" d="M17.2 20.7501C17.0776 20.7499 16.9573 20.7189 16.85 20.6601L12 18.1101L7.14999 20.6601C7.02675 20.7262 6.88746 20.7566 6.74786 20.7478C6.60825 20.7389 6.47391 20.6912 6.35999 20.6101C6.24625 20.5267 6.15796 20.4133 6.10497 20.2826C6.05199 20.1519 6.03642 20.0091 6.05999 19.8701L6.99999 14.4701L3.05999 10.6501C2.96124 10.5512 2.89207 10.4268 2.86027 10.2907C2.82846 10.1547 2.83529 10.0124 2.87999 9.88005C2.92186 9.74719 3.00038 9.62884 3.10652 9.53862C3.21266 9.4484 3.34211 9.38997 3.47999 9.37005L8.89999 8.58005L11.33 3.67005C11.3991 3.55403 11.4973 3.45795 11.6147 3.39123C11.7322 3.32451 11.8649 3.28943 12 3.28943C12.1351 3.28943 12.2678 3.32451 12.3853 3.39123C12.5027 3.45795 12.6008 3.55403 12.67 3.67005L15.1 8.58005L20.52 9.37005C20.6579 9.38997 20.7873 9.4484 20.8935 9.53862C20.9996 9.62884 21.0781 9.74719 21.12 9.88005C21.1647 10.0124 21.1715 10.1547 21.1397 10.2907C21.1079 10.4268 21.0387 10.5512 20.94 10.6501L17 14.4701L17.93 19.8701C17.9536 20.0091 17.938 20.1519 17.885 20.2826C17.832 20.4133 17.7437 20.5267 17.63 20.6101C17.5034 20.6976 17.3539 20.7463 17.2 20.7501ZM12 16.5201C12.121 16.5215 12.2403 16.5488 12.35 16.6001L16.2 18.6001L15.47 14.3101C15.4502 14.1897 15.4589 14.0664 15.4953 13.9501C15.5318 13.8337 15.595 13.7275 15.68 13.6401L18.8 10.6401L14.49 10.0001C14.3708 9.98109 14.2578 9.93401 14.1605 9.86271C14.0631 9.79141 13.9841 9.69795 13.93 9.59005L12 5.69005L10.07 9.60005C10.0159 9.70795 9.9369 9.80141 9.83952 9.87271C9.74214 9.94401 9.62918 9.99109 9.50999 10.0101L5.19999 10.6401L8.31999 13.6401C8.40493 13.7275 8.46817 13.8337 8.50464 13.9501C8.54111 14.0664 8.54979 14.1897 8.52999 14.3101L7.79999 18.6301L11.65 16.6301C11.7573 16.5683 11.8767 16.5308 12 16.5201Z"/>
                            </svg>
                            <div class="absolute">
                                <div class="inline-block overflow-hidden whitespace-nowrap" v-bind:style="{ 'width': (film.averageRating / maxStarRating) * 100 + '%' }">
                                    <svg v-for="n in maxStarRating" class="inline-block" width="20px" height="20px" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                                        <path class="fill-yellow-400" d="M21.12 9.88005C21.0781 9.74719 20.9996 9.62884 20.8935 9.53862C20.7873 9.4484 20.6579 9.38997 20.52 9.37005L15.1 8.58005L12.67 3.67005C12.6008 3.55403 12.5027 3.45795 12.3853 3.39123C12.2678 3.32451 12.1351 3.28943 12 3.28943C11.8649 3.28943 11.7322 3.32451 11.6147 3.39123C11.4973 3.45795 11.3991 3.55403 11.33 3.67005L8.89999 8.58005L3.47999 9.37005C3.34211 9.38997 3.21266 9.4484 3.10652 9.53862C3.00038 9.62884 2.92186 9.74719 2.87999 9.88005C2.83529 10.0124 2.82846 10.1547 2.86027 10.2907C2.89207 10.4268 2.96124 10.5512 3.05999 10.6501L6.99999 14.4701L6.06999 19.8701C6.04642 20.0091 6.06199 20.1519 6.11497 20.2826C6.16796 20.4133 6.25625 20.5267 6.36999 20.6101C6.48391 20.6912 6.61825 20.7389 6.75785 20.7478C6.89746 20.7566 7.03675 20.7262 7.15999 20.6601L12 18.1101L16.85 20.6601C16.9573 20.7189 17.0776 20.7499 17.2 20.7501C17.3573 20.7482 17.5105 20.6995 17.64 20.6101C17.7537 20.5267 17.842 20.4133 17.895 20.2826C17.948 20.1519 17.9636 20.0091 17.94 19.8701L17 14.4701L20.93 10.6501C21.0305 10.5523 21.1015 10.4283 21.1351 10.2922C21.1687 10.1561 21.1634 10.0133 21.12 9.88005Z"/>
                                    </svg>
                                </div>
                            </div>
                        </div>
                        <p class="ml-1 whitespace-nowrap">{{ film.averageRating.toFixed(2) }} / {{ maxStarRating }} {{ `(${film.reviewsCount} review${film.reviewsCount !== 1 ? 's' : ''})` }}</p>
                    </div>
                    
                    <p class="text-base">Genre: {{ film.genre }}</p>
                    <p class="text-base">Duration: {{ `${film.duration.getUTCHours()} hour${film.duration.getUTCHours() !== 1 ? 's' : ''} ${film.duration.getUTCMinutes()} minute${film.duration.getUTCMinutes() !== 1 ? 's' : ''}` }}</p>
                    <p class="text-base">Release date: {{ `${film.releaseDate.getUTCDate().toString().padStart(2, '0')}-${(film.releaseDate.getUTCMonth() + 1).toString().padStart(2, '0')}-${film.releaseDate.getUTCFullYear()}` }}</p>
                </div>
            </div>
        </div>
    </div>
</template>

<script lang="ts">
    import axios from 'axios'
    import { type FilmBasicInfoType } from '../types/FilmBasicInfoType'
    import NavbarComponent from '../components/NavbarComponent.vue'

    export default {
        components: {
            NavbarComponent
        },
        data() {
            return {
                films: [] as FilmBasicInfoType[],
                maxStarRating: 10 as const
            }
        },
        mounted() {
            this.getFilms()
        },
        methods: {
            //date.toLocaleString('en-US', {year: 'numeric', month: 'long', day: 'numeric' })
            //new Date().ToISOSting().slice(0, 10)
            async getFilms() {
                try {
                    const response = await axios.get<FilmBasicInfoType[]>('/Film/all')
                    this.films = response.data.map((film: FilmBasicInfoType) => {
                        const [, hours, minutes] = film.duration.toString().split(":").map(Number)
                        
                        const duration = new Date()
                        duration.setUTCHours(hours)
                        duration.setUTCMinutes(minutes)
                        duration.setUTCSeconds(0)
                        duration.setUTCMilliseconds(0)

                        return {
                            ...film,
                            releaseDate: new Date(film.releaseDate.toString() + 'T00:00:00.000Z'),
                            duration: duration
                        }
                    })

                } catch (error) {
                    this.$toast.open({
                        message: 'Failed to download the films.',
                        type: 'error'
                    })
                }
            }
        }
    }
</script>
