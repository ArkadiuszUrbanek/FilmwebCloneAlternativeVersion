<template>
    <navbar-component v-on:logOut="handleLogout"></navbar-component>
    <div v-if="forumPagedResponse" class="container w-full md:w-4/5 xl:w-3/5 mx-auto px-2">
        <div class="pb-2 rounded shadow block mt-6">
            <table class="w-full text-center">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th v-on:click="sort('MessagesCount')"
                            class="cursor-pointer hover:bg-gray-100 rounded-t-[20px]">
                            <div class="flex justify-center">
                                Replies count
                                <template v-if="currentSortingProperty === 'MessagesCount'">
                                    <svg v-if="currentSortingOrder === 'Descending'" xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-caret-down-filled" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"/><path d="M18 9c.852 0 1.297 .986 .783 1.623l-.076 .084l-6 6a1 1 0 0 1 -1.32 .083l-.094 -.083l-6 -6l-.083 -.094l-.054 -.077l-.054 -.096l-.017 -.036l-.027 -.067l-.032 -.108l-.01 -.053l-.01 -.06l-.004 -.057v-.118l.005 -.058l.009 -.06l.01 -.052l.032 -.108l.027 -.067l.07 -.132l.065 -.09l.073 -.081l.094 -.083l.077 -.054l.096 -.054l.036 -.017l.067 -.027l.108 -.032l.053 -.01l.06 -.01l.057 -.004l12.059 -.002z" stroke-width="0" fill="currentColor" />
                                    </svg>
                                    <svg v-else xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-caret-up-filled" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"/><path d="M11.293 7.293a1 1 0 0 1 1.32 -.083l.094 .083l6 6l.083 .094l.054 .077l.054 .096l.017 .036l.027 .067l.032 .108l.01 .053l.01 .06l.004 .057l.002 .059l-.002 .059l-.005 .058l-.009 .06l-.01 .052l-.032 .108l-.027 .067l-.07 .132l-.065 .09l-.073 .081l-.094 .083l-.077 .054l-.096 .054l-.036 .017l-.067 .027l-.108 .032l-.053 .01l-.06 .01l-.057 .004l-.059 .002h-12c-.852 0 -1.297 -.986 -.783 -1.623l.076 -.084l6 -6z" stroke-width="0" fill="currentColor" />
                                    </svg>
                                </template>
                            </div>
                        </th>
                        <th>Author</th>
                        <th v-on:click="sort('CreationDate')"
                            class="cursor-pointer hover:bg-gray-100 rounded-t-[20px]">
                            <div class="flex justify-center">
                                Created
                                <template v-if="currentSortingProperty === 'CreationDate'">
                                    <svg v-if="currentSortingOrder === 'Descending'" xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-caret-down-filled" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"/><path d="M18 9c.852 0 1.297 .986 .783 1.623l-.076 .084l-6 6a1 1 0 0 1 -1.32 .083l-.094 -.083l-6 -6l-.083 -.094l-.054 -.077l-.054 -.096l-.017 -.036l-.027 -.067l-.032 -.108l-.01 -.053l-.01 -.06l-.004 -.057v-.118l.005 -.058l.009 -.06l.01 -.052l.032 -.108l.027 -.067l.07 -.132l.065 -.09l.073 -.081l.094 -.083l.077 -.054l.096 -.054l.036 -.017l.067 -.027l.108 -.032l.053 -.01l.06 -.01l.057 -.004l12.059 -.002z" stroke-width="0" fill="currentColor" />
                                    </svg>
                                    <svg v-else xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-caret-up-filled" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"/><path d="M11.293 7.293a1 1 0 0 1 1.32 -.083l.094 .083l6 6l.083 .094l.054 .077l.054 .096l.017 .036l.027 .067l.032 .108l.01 .053l.01 .06l.004 .057l.002 .059l-.002 .059l-.005 .058l-.009 .06l-.01 .052l-.032 .108l-.027 .067l-.07 .132l-.065 .09l-.073 .081l-.094 .083l-.077 .054l-.096 .054l-.036 .017l-.067 .027l-.108 .032l-.053 .01l-.06 .01l-.057 .004l-.059 .002h-12c-.852 0 -1.297 -.986 -.783 -1.623l.076 -.084l6 -6z" stroke-width="0" fill="currentColor" />
                                    </svg>
                                </template>
                            </div>
                        </th>
                        <th v-if="isAnyActionAllowed">Actions</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="(forum, index) in forumPagedResponse.forums" :key="forum.id"
                        v-on:click="routeToMessages(forum.id, forum.name)"
                        :class="{ 'bg-gray-100': index % 2 === 0 }"
                        class="hover:bg-gray-200 cursor-pointer"
                    >   
                        <td>{{ forum.name }}</td>
                        <td>
                            <div class="grid grid-cols-2">
                                <p class="text-right mr-2">{{ forum.messagesCount }}</p>
                                <svg xmlns="http://www.w3.org/2000/svg" class="icon icon-tabler icon-tabler-message" width="24" height="24" viewBox="0 0 24 24" stroke-width="2" stroke="currentColor" fill="none" stroke-linecap="round" stroke-linejoin="round"><path stroke="none" d="M0 0h24v24H0z" fill="none"/><path d="M8 9h8" /><path d="M8 13h6" /><path d="M18 4a3 3 0 0 1 3 3v8a3 3 0 0 1 -3 3h-5l-5 3v-3h-2a3 3 0 0 1 -3 -3v-8a3 3 0 0 1 3 -3h12z" />
                                </svg>
                            </div>
                        </td>
                        <td>{{ `${forum.author.firstName} ${forum.author.lastName}` }}</td>
                        <td>
                            <p>
                                {{ getFormattedDate(forum.creationDate.toString()) }}
                            </p>
                            <p>
                                {{ getFormattedTime(forum.creationDate.toString()) }}
                            </p>
                        </td>
                        <td v-if="isAnyActionAllowed">
                            <div v-if="forum.author.id === $store.getters.sub" class="block">
                                <button v-on:click.stop="removeForum(forum.id)"
                                        class="m-auto py-[2px] px-[4px] bg-red-500 hover:bg-red-600 shadow-lg flex items-center justify-center rounded font-medium text-white">
                                    Delete
                                    <svg class="fill-white" xmlns="http://www.w3.org/2000/svg"  viewBox="0 0 32 32" width="24px" height="24px">
                                        <path d="M 15 4 C 14.476563 4 13.941406 4.183594 13.5625 4.5625 C 13.183594 4.941406 13 5.476563 13 6 L 13 7 L 7 7 L 7 9 L 8 9 L 8 25 C 8 26.644531 9.355469 28 11 28 L 23 28 C 24.644531 28 26 26.644531 26 25 L 26 9 L 27 9 L 27 7 L 21 7 L 21 6 C 21 5.476563 20.816406 4.941406 20.4375 4.5625 C 20.058594 4.183594 19.523438 4 19 4 Z M 15 6 L 19 6 L 19 7 L 15 7 Z M 10 9 L 24 9 L 24 25 C 24 25.554688 23.554688 26 23 26 L 11 26 C 10.445313 26 10 25.554688 10 25 Z M 12 12 L 12 23 L 14 23 L 14 12 Z M 16 12 L 16 23 L 18 23 L 18 12 Z M 20 12 L 20 23 L 22 23 L 22 12 Z"/>
                                    </svg>
                                </button>
                            </div>
                        </td>
                    </tr>
                </tbody>
            </table>
            <div class="flex justify-center mt-2">
                <button v-on:click="previousPage()"
                        v-bind:class="{'invisible': currentPageNumber === 1}"
                        class="flex items-center justify-center px-4 h-8 mr-2 text-base font-medium text-gray-500 bg-white border border-gray-300 rounded-lg hover:bg-gray-100 hover:text-gray-700">
                    <svg class="w-3.5 h-3.5 me-2 rtl:rotate-180" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 14 10">
                        <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M13 5H1m0 0 4 4M1 5l4-4"/>
                    </svg>
                    Previous
                </button>
                <div class="flex space-x-2 items-center">
                    <template v-for="pageNumber in forumPagedResponse.pagesCount">
                        <button v-on:click="getPage(pageNumber)"
                                v-bind:disabled="currentPageNumber === pageNumber"
                                v-bind:class="{
                                    'text-black border-2 border-black font-medium': currentPageNumber === pageNumber,
                                    'bg-white text-gray-500 border border-gray-300 hover:bg-gray-100 hover:text-gray-700': currentPageNumber !== pageNumber
                                }"
                                class="rounded flex items-center justify-center w-8 h-8 leading-tight   ">
                            {{ pageNumber }}
                        </button>
                    </template>
                </div>
                <button v-on:click="nextPage()"
                        v-bind:class="{'invisible': currentPageNumber === forumPagedResponse.pagesCount}"
                        class="flex items-center justify-center px-4 h-8 ml-2 text-base font-medium text-gray-500 bg-white border border-gray-300 rounded-lg hover:bg-gray-100 hover:text-gray-700">
                    Next
                    <svg class="w-3.5 h-3.5 ms-2 rtl:rotate-180" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 14 10">
                        <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M1 5h12m0 0L9 1m4 4L9 9"/>
                    </svg>
                </button>
            </div>
        </div>
    </div>
    <div
        v-if="$store.getters.isLoggedIn"
        v-on:click="onAddForum"
        class="bg-amber-400 hover:bg-amber-500 rounded-full h-16 w-16 shadow-lg cursor-pointer flex items-center justify-center fixed bottom-4 right-4">
          <svg class="w-12 h-12" aria-hidden="true" xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24">
            <path stroke="currentColor" stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M5 12h14m-7 7V5"/>
          </svg>
    </div>
    <widget-container-modal/>
</template>

<script lang="ts">
    import type { ForumPagedResponseType } from '../types/ForumPagedResponseType'
    import type { ForumSortPropertyType } from '../types/ForumSortPropertyType'
    import type { ForumSortOrderType } from '../types/ForumSortOrderType'
    import NavbarComponent from '../components/NavbarComponent.vue'
    import { container, promptModal } from "jenesius-vue-modal"
    import ForumModalComponent from '../components/ForumModalComponent.vue'
    import axios from 'axios'

    export default {
        components: {
            NavbarComponent,
            WidgetContainerModal: container
        },
        data() {
            return {
                forumPagedResponse: undefined as ForumPagedResponseType | undefined,
                currentPageNumber: 1 as number,
                currentPageSize: 10 as number,
                currentSortingProperty: 'CreationDate' as ForumSortPropertyType,
                currentSortingOrder: 'Descending' as ForumSortOrderType,
                isAnyActionAllowed: false as Boolean
            }
        },
        mounted() {
            this.getForums()
        },
        methods: {
            async getForums() {
                try {
                    const response = await axios.get<ForumPagedResponseType>('/Forum', {
                        params: {
                            pageNumber: this.currentPageNumber,
                            pageSize: this.currentPageSize,
                            sortingProperty: this.currentSortingProperty,
                            sortingOrder: this.currentSortingOrder
                        }
                    })

                    this.isAnyActionAllowed = false

                    this.forumPagedResponse = {
                        ...response.data,
                        forums: response.data.forums.map((forum) => {
                            if (forum.author.id === this.$store.getters.sub) this.isAnyActionAllowed = true

                            return {
                                ...forum,
                                creationDate: new Date(forum.creationDate),
                                author: { ...forum.author }
                            }
                        })
                    }

                } catch (error) {
                    this.$toast.open({
                        message: 'Failed to download the forums.',
                        type: 'error'
                    })
                }
            },
            getFormattedDate(dateTimeString: string): string {
                const dateTimeObject = new Date(dateTimeString)
                return `${dateTimeObject.getDate().toString().padStart(2, '0')}-${(dateTimeObject.getMonth() + 1).toString().padStart(2, '0')}-${dateTimeObject.getFullYear()}`
            },
            getFormattedTime(dateTimeString: string): string {
                const dateTimeObject = new Date(dateTimeString)
                return `${dateTimeObject.getHours().toString().padStart(2, '0')}:${dateTimeObject.getMinutes().toString().padStart(2, '0')}`
            },
            sort(sortingProperty: ForumSortPropertyType) {
                if (this.currentSortingProperty !== sortingProperty) {
                    this.currentSortingProperty = sortingProperty
                    this.currentSortingOrder = 'Descending'

                } else {
                    if (this.currentSortingOrder === 'Ascending') this.currentSortingOrder = 'Descending'
                    else if (this.currentSortingOrder === 'Descending') this.currentSortingOrder = 'Ascending'

                }

                this.getForums()
            },
            nextPage() {
                if (this.currentPageNumber === this.forumPagedResponse!.pagesCount) return
                this.currentPageNumber++
                this.getForums()
            },
            previousPage() {
                if (this.currentPageNumber === 1) return
                this.currentPageNumber--
                this.getForums()
            },
            getPage(pageNumber: number) {
                this.currentPageNumber = pageNumber
                this.getForums()
            },
            handleLogout() {
                this.isAnyActionAllowed = false
            },
            async removeForum(forumId: number) {
                try {
                    const response = await axios.delete(`/Forum/${forumId}/delete`, {
                        headers: {
                            'Authorization': `Bearer ${this.$store.getters.token}`,
                        }
                    })

                    this.getForums()

                } catch(error) {
                    this.$toast.open({
                        message: 'Failed to remove the forum.',
                        type: 'error'
                    })
                }
            },
            async onAddForum() {
              const modal = (await promptModal(ForumModalComponent)) as { name: string, initialMessageText: string }
              
              try {
                  const response = await axios.put<number>('/Forum', { ...modal },
                    {
                      headers: {
                        'Authorization': `Bearer ${this.$store.getters.token}`,
                      }
                    }
                  )
                  
                  this.getForums()

                } catch (error) {
                    this.$toast.open({
                        message: 'Failed to add the forum.',
                        type: 'error'
                    })
                }
            },
            routeToMessages(forumId: number, forumName: string) {
                this.$router.push({ name: 'forum-messages', 
                params: {
                        forumId: forumId
                    } 
                })
            }
        }
    }
</script>