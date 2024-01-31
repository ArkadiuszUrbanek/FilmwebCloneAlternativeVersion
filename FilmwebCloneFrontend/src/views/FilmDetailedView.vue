<template>
    <navbar-component v-on:logOut="handleLogout" class="relative z-50"></navbar-component>
    <div v-if="film" class="flex flex-col items-center z-0">
    <div class="w-full h-[400px] relative inline-block gradient-overlay">
      <img v-bind:src="film.bannerPath" class="h-full w-full object-cover "/>
    </div>
    <div class="flex w-full">
    <div class="w-1/3 pr-4 relative">
      <img v-bind:src="film.posterPath" class="shadow-lg h-[300px] absolute right-0 top-0 mt-[-200px] mr-[16px]"/>
      <div class="text-sm float-right mr-[15px] mt-[110px]">
        <p><span class="font-medium">Genre: </span>{{ film.genre }}</p>
        <p><span class="font-medium">Duration: </span>{{ `${film.duration.getUTCHours()} hour${film.duration.getUTCHours() !== 1 ? 's' : ''} ${film.duration.getUTCMinutes()} minute${film.duration.getUTCMinutes() !== 1 ? 's' : ''}` }}</p>
        <p><span class="font-medium">Release date: </span>{{ `${film.releaseDate.getUTCDate().toString().padStart(2, '0')}-${(film.releaseDate.getUTCMonth() + 1).toString().padStart(2, '0')}-${film.releaseDate.getUTCFullYear()}` }}</p>
      </div>
    </div>
    <div class="w-2/3 pl-1 pt-1 relative">
      <div class="absolute top-0 mt-[-140px] ml-[4px]">
      <div class="text-4xl text-white mb-3 font-medium">{{ film.title }}</div>
      <div v-if="film?.subtitle" class="text-gray-300 text-2xl font-medium mb-4">{{ film.subtitle }}</div>    
      <div class="flex">
        <div class="flex items-center relative">
          <svg v-for="n in maxStarRating" width="20px" height="20px" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
            <path class="fill-yellow-400" d="M17.2 20.7501C17.0776 20.7499 16.9573 20.7189 16.85 20.6601L12 18.1101L7.14999 20.6601C7.02675 20.7262 6.88746 20.7566 6.74786 20.7478C6.60825 20.7389 6.47391 20.6912 6.35999 20.6101C6.24625 20.5267 6.15796 20.4133 6.10497 20.2826C6.05199 20.1519 6.03642 20.0091 6.05999 19.8701L6.99999 14.4701L3.05999 10.6501C2.96124 10.5512 2.89207 10.4268 2.86027 10.2907C2.82846 10.1547 2.83529 10.0124 2.87999 9.88005C2.92186 9.74719 3.00038 9.62884 3.10652 9.53862C3.21266 9.4484 3.34211 9.38997 3.47999 9.37005L8.89999 8.58005L11.33 3.67005C11.3991 3.55403 11.4973 3.45795 11.6147 3.39123C11.7322 3.32451 11.8649 3.28943 12 3.28943C12.1351 3.28943 12.2678 3.32451 12.3853 3.39123C12.5027 3.45795 12.6008 3.55403 12.67 3.67005L15.1 8.58005L20.52 9.37005C20.6579 9.38997 20.7873 9.4484 20.8935 9.53862C20.9996 9.62884 21.0781 9.74719 21.12 9.88005C21.1647 10.0124 21.1715 10.1547 21.1397 10.2907C21.1079 10.4268 21.0387 10.5512 20.94 10.6501L17 14.4701L17.93 19.8701C17.9536 20.0091 17.938 20.1519 17.885 20.2826C17.832 20.4133 17.7437 20.5267 17.63 20.6101C17.5034 20.6976 17.3539 20.7463 17.2 20.7501ZM12 16.5201C12.121 16.5215 12.2403 16.5488 12.35 16.6001L16.2 18.6001L15.47 14.3101C15.4502 14.1897 15.4589 14.0664 15.4953 13.9501C15.5318 13.8337 15.595 13.7275 15.68 13.6401L18.8 10.6401L14.49 10.0001C14.3708 9.98109 14.2578 9.93401 14.1605 9.86271C14.0631 9.79141 13.9841 9.69795 13.93 9.59005L12 5.69005L10.07 9.60005C10.0159 9.70795 9.9369 9.80141 9.83952 9.87271C9.74214 9.94401 9.62918 9.99109 9.50999 10.0101L5.19999 10.6401L8.31999 13.6401C8.40493 13.7275 8.46817 13.8337 8.50464 13.9501C8.54111 14.0664 8.54979 14.1897 8.52999 14.3101L7.79999 18.6301L11.65 16.6301C11.7573 16.5683 11.8767 16.5308 12 16.5201Z"/>
          </svg>
          <div class="absolute">
            <div class="inline-block overflow-hidden whitespace-nowrap" v-bind:style="{ 'width': (film.averageRating / maxStarRating) * 100 + '%' }">
              <svg v-for="n in maxStarRating" class="inline" width="20px" height="20px" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg">
                <path class="fill-yellow-400" d="M21.12 9.88005C21.0781 9.74719 20.9996 9.62884 20.8935 9.53862C20.7873 9.4484 20.6579 9.38997 20.52 9.37005L15.1 8.58005L12.67 3.67005C12.6008 3.55403 12.5027 3.45795 12.3853 3.39123C12.2678 3.32451 12.1351 3.28943 12 3.28943C11.8649 3.28943 11.7322 3.32451 11.6147 3.39123C11.4973 3.45795 11.3991 3.55403 11.33 3.67005L8.89999 8.58005L3.47999 9.37005C3.34211 9.38997 3.21266 9.4484 3.10652 9.53862C3.00038 9.62884 2.92186 9.74719 2.87999 9.88005C2.83529 10.0124 2.82846 10.1547 2.86027 10.2907C2.89207 10.4268 2.96124 10.5512 3.05999 10.6501L6.99999 14.4701L6.06999 19.8701C6.04642 20.0091 6.06199 20.1519 6.11497 20.2826C6.16796 20.4133 6.25625 20.5267 6.36999 20.6101C6.48391 20.6912 6.61825 20.7389 6.75785 20.7478C6.89746 20.7566 7.03675 20.7262 7.15999 20.6601L12 18.1101L16.85 20.6601C16.9573 20.7189 17.0776 20.7499 17.2 20.7501C17.3573 20.7482 17.5105 20.6995 17.64 20.6101C17.7537 20.5267 17.842 20.4133 17.895 20.2826C17.948 20.1519 17.9636 20.0091 17.94 19.8701L17 14.4701L20.93 10.6501C21.0305 10.5523 21.1015 10.4283 21.1351 10.2922C21.1687 10.1561 21.1634 10.0133 21.12 9.88005Z"/>
              </svg>
            </div>
          </div>
        </div>
        <p class="ml-1 text-gray-300">{{ `${film.averageRating.toFixed(2)} / ${maxStarRating} (${film.reviewsCount} review${film.reviewsCount !== 1 ? 's' : ''})` }}</p>
      </div>
      </div>
      <div class="w-1/2">
        <p class="text-justify ml-2">{{ film.description }}</p>
        <h1 class="font-bold text-xl mt-5 ml-2">Actors</h1>
        <Carousel v-bind="settings" :breakpoints="breakpoints">
          <Slide v-for="actor in actors" :key="actor.id">
            <router-link v-bind:to="{ name: 'person-details', params: { personId: actor.id } }" class="shadow-lg rounded-lg overflow-hidden group">
              <div class="w-[200px] h-[300px] overflow-hidden rounded-t-lg relative">
                <img class="absolute top-0 left-0 w-full h-full object-cover" v-bind:src="actor.picturePath">
                <div class="absolute bottom-0 left-0 right-0 p-2 text-center bg-gradient-to-b from-transparent to-black text-white opacity-0 group-hover:opacity-100  duration-300 translate-y-6 group-hover:translate-y-0">
                  <p class="text-lg font-medium">{{ `${actor.firstName} ${actor.lastName}`}}</p>
                </div>
              </div>
            </router-link>
          </Slide>
          <template #addons>
            <Navigation>
              <template #next> 
                <div class="carousel__next"> 
                  <svg width="25px" height="25px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                    <path d="M9 6L15 12L9 18" stroke="#000000" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/>
                  </svg>
                </div> 
              </template> 
              <template #prev> 
                <div class="carousel__prev"> 
                  <svg width="25px" height="25px" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                    <path d="M15 6L9 12L15 18" stroke="#000000" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/>
                  </svg>
                </div> 
              </template>
            </Navigation>
          </template>
        </Carousel>

        
    
      <div class="flex items-center gap-x-3 mt-2">
        <h1 class="font-bold text-xl">Reviews</h1>
        <div
          v-if="$store.getters.isLoggedIn && !currentUserReviewId"
          v-on:click="onAddReview"
          class="bg-amber-400 hover:bg-amber-500 rounded-full h-10 w-10 shadow-lg cursor-pointer flex items-center justify-center text-white">
          <svg class="w-6 h-6 text-black " aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24">
            <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M5 12h14m-7 7V5"/>
          </svg>
        </div>
      </div>

    <div 
      v-for="review in reviews" :key="review.id" 
      class="bg-white rounded-2xl px-5 py-5 shadow-lg hover:shadow-2xl transition duration-500 border mt-2 relative">

      <div
          v-on:click="removeReview(review.id)"
          v-if="currentUserReviewId && currentUserReviewId === review.id"
          class="bg-red-500 hover:bg-red-600 rounded-full h-10 w-10 shadow-lg cursor-pointer flex items-center justify-center text-white absolute top-0 right-0 mt-[10px] mr-[10px]">
          <svg xmlns="http://www.w3.org/2000/svg"  viewBox="0 0 32 32" width="24px" height="24px">
            <path d="M 15 4 C 14.476563 4 13.941406 4.183594 13.5625 4.5625 C 13.183594 4.941406 13 5.476563 13 6 L 13 7 L 7 7 L 7 9 L 8 9 L 8 25 C 8 26.644531 9.355469 28 11 28 L 23 28 C 24.644531 28 26 26.644531 26 25 L 26 9 L 27 9 L 27 7 L 21 7 L 21 6 C 21 5.476563 20.816406 4.941406 20.4375 4.5625 C 20.058594 4.183594 19.523438 4 19 4 Z M 15 6 L 19 6 L 19 7 L 15 7 Z M 10 9 L 24 9 L 24 25 C 24 25.554688 23.554688 26 23 26 L 11 26 C 10.445313 26 10 25.554688 10 25 Z M 12 12 L 12 23 L 14 23 L 14 12 Z M 16 12 L 16 23 L 18 23 L 18 12 Z M 20 12 L 20 23 L 22 23 L 22 12 Z"/>
          </svg>
        </div>

        <h1 class="text-lg text-gray-700 font-semibold">{{ review.title }}</h1>
        <div class="flex items-center mt-2">
          <svg xmlns="http://www.w3.org/2000/svg" class="h-6 w-6 text-yellow-400" viewBox="0 0 20 20" fill="currentColor">
            <path d="M9.049 2.927c.3-.921 1.603-.921 1.902 0l1.07 3.292a1 1 0 00.95.69h3.462c.969 0 1.371 1.24.588 1.81l-2.8 2.034a1 1 0 00-.364 1.118l1.07 3.292c.3.921-.755 1.688-1.54 1.118l-2.8-2.034a1 1 0 00-1.175 0l-2.8 2.034c-.784.57-1.838-.197-1.539-1.118l1.07-3.292a1 1 0 00-.364-1.118L2.98 8.72c-.783-.57-.38-1.81.588-1.81h3.461a1 1 0 00.951-.69l1.07-3.292z" />
          </svg>
          <p class="ml-1">{{`${review.rating} / ${maxStarRating}`}}</p>
        </div>
        <p class="mt-4 text-md text-gray-600 text-justify">{{ review.description }}</p>
        <div class="flex justify-between items-center">
          <div class="mt-4 flex items-center space-x-2 ">
            <svg v-if="review.author.gender === 'Male'" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 48 48" width="48px" height="48px">
              <path fill="#ffe082" d="M41.5,26.9c0,0,0-0.4,0-2.4c0-2.2-0.8-4.1-1.1-4.6c0.4-0.1,0.7-0.2,0.9-0.2c0.9-0.3,1.4-1.3,1-2.2	c-2.3-4.7-7.1-8-13.9-8c-9,0-14,5-14,13v4.4c-1.2,0.6-2,1.7-2,3.1c0,1.3,0.7,2.4,1.7,3c0.3,0.2,0.8,1.8,1.7,3.2	c0.6,1,1.6,1.8,1.9,2.4c2.3,4.7,6,7.9,10.2,7.9c5.6,0,10.4-5.5,11.9-13c0,0,0,0,0.1,0c1.9,0,3.5-1.6,3.5-3.5	C43.5,28.6,42.7,27.4,41.5,26.9z"/>
              <circle cx="19" cy="26" r="2" fill="#18193f"/><circle cx="29" cy="26" r="2" fill="#18193f"/><path fill="none" stroke="#18193f" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" stroke-width="3" d="M19.2,6.2c-5.6,1.6-8.7,6-8.7,12.3v4.4c-1.2,0.6-2,1.7-2,3.1c0,1.9,1.6,3.5,3.5,3.5c0,0,0,0,0.1,0	c1.6,7.5,6.3,13,11.9,13s10.4-5.5,11.9-13c0,0,0,0,0.1,0c1.9,0,3.5-1.6,3.5-3.5c0-1.4-0.8-2.6-2-3.1"/>
              <path fill="none" stroke="#18193f" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" stroke-width="3" d="M16.5,16.5c1.9-1.5,2.5-3,2.5-3s3,3,11,3c3.3,0,6-0.5,7.4-0.9c0.9-0.3,1.4-1.3,1-2.2C36.3,9.1,32,6,26,5.6"/>
            </svg>
            <svg v-else-if="review.author.gender === 'Female'" xmlns="http://www.w3.org/2000/svg"  viewBox="0 0 48 48" width="48px" height="48px">
              <path fill="#ffe082" d="M34,12c0,0-2-2.5-7-2.5c-9.8,0-18.5,7-18.5,26v5c0,2.2,1.8,4,4,4h9.8c1.7,1.3,3.6,2,5.7,2s4-0.7,5.7-2h9.8	c2.2,0,4-1.8,4-4v-5C47.5,16.5,38.3,12,34,12z"/>
              <path fill="none" stroke="#18193f" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" stroke-width="3" d="M14.5,19.5c0,0,9.5,0,14-4c0,0,8,1,8,10c-0.5,9.5-5.9,17-12.5,17s-12-7.5-12.5-17"/><path fill="none" stroke="#18193f" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" stroke-width="3" d="M5.6,20.8c-0.7,3-1.1,6.6-1.1,10.7v5c0,2.2,1.8,4,4,4h3.6"/>
              <path fill="none" stroke="#18193f" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" stroke-width="3" d="M36.5,40.5h3c2.2,0,4-1.8,4-4v-5C43.5,12.5,34.3,8,30,8c0,0-2-2.5-7-2.5c-5.7,0-11,2.4-14.5,8.1"/><circle cx="19" cy="28" r="2" fill="#18193f"/>
              <circle cx="29" cy="28" r="2" fill="#18193f"/>
            </svg>
            <div class="text-sm font-semibold">{{ `${review.author.firstName} ${review.author.lastName}` }} • <span class="font-normal"> {{ getFormattedReviewDateString(review.creationDate.toString()) }}</span></div>
          </div>
          
        </div>
    </div>

      </div>
    </div>
    </div>

    </div>
    <widget-container-modal/>
</template>

<script lang="ts">
    import type { PersonPositionType } from '../types/PersonPositionType'
    import type { FilmDetailedInfoType } from '../types/FilmDetailedInfoType'
    import type { PersonBasicInfoType } from '../types/PersonBasicInfoType'
    import type { ReviewInfoType } from '../types/ReviewInfoType'
    import NavbarComponent from '../components/NavbarComponent.vue'
    import ReviewModalComponent from '../components/ReviewModalComponent.vue'
    import { container, promptModal } from 'jenesius-vue-modal'
    import { Carousel, Navigation, Slide } from 'vue3-carousel'
    import axios from 'axios'

    import 'vue3-carousel/dist/carousel.css'

    export default {
        components: {
            Carousel,
            Slide,
            Navigation,
            NavbarComponent,
            WidgetContainerModal: container
        },
        mounted() {
            this.getFilm()
            this.getActors()
            this.getReviews()
        },
        props: ['filmId'],
        data() {
            return {
                film: undefined as FilmDetailedInfoType | undefined,
                actors: [] as PersonBasicInfoType[],
                currentUserReviewId: undefined as number | undefined,
                reviews: [] as ReviewInfoType[],
                maxStarRating: 10 as number,
                settings: {
                    itemsToShow: 1,
                    snapAlign: 'center' as 'start' | 'end' | 'center' | 'center-even' | 'center-odd',
                    mouseDrag: false
                },
                breakpoints: {
                    1340: {
                        itemsToShow: 2,
                        snapAlign: 'center-even',
                    },
                    2000: {
                        itemsToShow: 3,
                        snapAlign: 'center-odd',
                    },
                }
            }
        },
        methods: {
            async getFilm() {
                try {
                    const response = await axios.get<FilmDetailedInfoType>(`/Film/${this.$props.filmId}`)

                    const [, hours, minutes] = response.data.duration.toString().split(":").map(Number)

                    const duration = new Date()
                    duration.setUTCHours(hours)
                    duration.setUTCMinutes(minutes)
                    duration.setUTCSeconds(0)
                    duration.setUTCMilliseconds(0)

                    this.film = {
                        ...response.data,
                        releaseDate: new Date(response.data.releaseDate.toString() + 'T00:00:00.000Z'),
                        duration: duration
                    }

                } catch (error) {
                    this.$toast.open({
                        message: 'Failed to download film\'s information.',
                        type: 'error'
                    })
                }
            },
            async getActors() {
                try {
                    const response = await axios.get('/Person/all', {
                        params: {
                            personPositions: 'Actor' as PersonPositionType,
                            filmId: this.$props.filmId
                        }
                    })

                    this.actors = response.data

                } catch (error) {
                    this.$toast.open({
                        message: 'Failed to download the actors.',
                        type: 'error'
                    })
                }
            },
            async getReviews() {
              try {
                  const response = await axios.get<ReviewInfoType[]>('/Review/all', {
                      params: {
                          filmId: this.$props.filmId
                      }
                  })

                  this.reviews = response.data.map((review: ReviewInfoType) => {
                      if (this.$store.getters.sub === review.author.id) this.currentUserReviewId = review.id
                      return {
                          ...review,
                          creationDateDate: new Date(review.creationDate),
                          author: { ...review.author }
                      }
                  })

                } catch (error) {
                    this.$toast.open({
                        message: 'Failed to download the review.',
                        type: 'error'
                    })
                }
            },
            async onAddReview() {
              const modal = (await promptModal(ReviewModalComponent)) as { title: string, rating: number, description: string }
              
              try {
                  const response = await axios.put<number>('/Review', {
                      ...modal,
                      filmId: this.$props.filmId
                    },
                    {
                      headers: {
                        'Authorization': `Bearer ${this.$store.getters.token}`,
                      }
                    }
                  )
                  this.currentUserReviewId = response.data
                  this.getReviews()

                } catch (error) {
                    this.$toast.open({
                        message: 'Failed to add review.',
                        type: 'error'
                    })
                }
            },
            getFormattedReviewDateString(reviewCreationDateString: string): string {
              const reviewCreationDateObject = new Date(reviewCreationDateString)
              const now = new Date()
              const secondsAgo = Math.floor((now.getTime() - reviewCreationDateObject.getTime()) / 1000)

              if (secondsAgo < 60) {
                return `${secondsAgo} second${secondsAgo !== 1 ? 's' : ''} ago`

              } else if (secondsAgo < 3600) {
                const minutesAgo = Math.floor(secondsAgo / 60);
                return `${minutesAgo} minute${minutesAgo !== 1 ? 's' : ''} ago`

              } else if (secondsAgo < 86400) {
                const hoursAgo = Math.floor(secondsAgo / 3600);
                return `${hoursAgo} hour${hoursAgo !== 1 ? 's' : ''} ago`

              } else if (secondsAgo < 2592000) {
                const daysAgo = Math.floor(secondsAgo / 86400);
                return `${daysAgo} day${daysAgo !== 1 ? 's' : ''} ago`

              } else if (secondsAgo < 31536000) {
                const monthsAgo = Math.floor(secondsAgo / 2592000);
                return `${monthsAgo} month${monthsAgo !== 1 ? 's' : ''} ago`

              } else {
                const yearsAgo = Math.floor(secondsAgo / 31536000);
                return `${yearsAgo} year${yearsAgo !== 1 ? 's' : ''} ago`

              }
            },
            async removeReview(reviewId: number) {
              try {
                  const response = await axios.delete<number>(`/Review/${reviewId}/delete`, {
                      headers: {
                        'Authorization': `Bearer ${this.$store.getters.token}`,
                      }
                    })

                  this.currentUserReviewId = undefined
                  this.getReviews()

                } catch (error) {
                    this.$toast.open({
                        message: 'Failed to remove the review.',
                        type: 'error'
                    })
                }
            },
            handleLogout() {
              this.currentUserReviewId = undefined
            }
        }
    }
</script>

<style scoped>
.carousel__slide {
    padding: 10px;
}

.carousel__prev,
.carousel__next {
	border-radius: 100%;
  width: fit-content;
  height: fit-content;
  background: rgb(250 204 21);
}

.carousel__prev:hover,
.carousel__next:hover {
  background: rgb(234 179 8);
}

.gradient-overlay::before {
  content: "";
  top: 0;
  left: 0;
  position: absolute;
  height: 100%;
  width: 100%;
  background: linear-gradient(to right, rgba(0, 0, 0, 1) 0%, rgba(0, 0, 0, 0.52) 50%, rgba(0, 0, 0, 1) 100%);
}
</style>