<template>
    <navbar-component v-on:logOut="handleLogout"></navbar-component>
    <div v-if="forumMessages" class="container md:w-4/5 xl:w-3/5 flex flex-col items-center mx-auto mt-6">
        <h1 class="text-5xl">{{ forumMessages.forumName }}</h1>
        <div class="w-full bg-white rounded-lg px-2 mt-6">
            <div class="flex flex-col">
                <div 
                    v-for="message in forumMessages.messages"
                    v-bind:key="message.id" 
                    class="border rounded-md p-3 mb-2 hover:shadow-lg relative transition-all group">
                    <div class="flex items-center relative">
                        <svg v-if="message.author.gender === 'Male'" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 48 48" width="48px" height="48px">
                              <path fill="#ffe082" d="M41.5,26.9c0,0,0-0.4,0-2.4c0-2.2-0.8-4.1-1.1-4.6c0.4-0.1,0.7-0.2,0.9-0.2c0.9-0.3,1.4-1.3,1-2.2	c-2.3-4.7-7.1-8-13.9-8c-9,0-14,5-14,13v4.4c-1.2,0.6-2,1.7-2,3.1c0,1.3,0.7,2.4,1.7,3c0.3,0.2,0.8,1.8,1.7,3.2	c0.6,1,1.6,1.8,1.9,2.4c2.3,4.7,6,7.9,10.2,7.9c5.6,0,10.4-5.5,11.9-13c0,0,0,0,0.1,0c1.9,0,3.5-1.6,3.5-3.5	C43.5,28.6,42.7,27.4,41.5,26.9z"/>
                              <circle cx="19" cy="26" r="2" fill="#18193f"/><circle cx="29" cy="26" r="2" fill="#18193f"/><path fill="none" stroke="#18193f" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" stroke-width="3" d="M19.2,6.2c-5.6,1.6-8.7,6-8.7,12.3v4.4c-1.2,0.6-2,1.7-2,3.1c0,1.9,1.6,3.5,3.5,3.5c0,0,0,0,0.1,0	c1.6,7.5,6.3,13,11.9,13s10.4-5.5,11.9-13c0,0,0,0,0.1,0c1.9,0,3.5-1.6,3.5-3.5c0-1.4-0.8-2.6-2-3.1"/>
                              <path fill="none" stroke="#18193f" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" stroke-width="3" d="M16.5,16.5c1.9-1.5,2.5-3,2.5-3s3,3,11,3c3.3,0,6-0.5,7.4-0.9c0.9-0.3,1.4-1.3,1-2.2C36.3,9.1,32,6,26,5.6"/>
                        </svg>
                        <svg v-else-if="message.author.gender === 'Female'" xmlns="http://www.w3.org/2000/svg"  viewBox="0 0 48 48" width="48px" height="48px">
                              <path fill="#ffe082" d="M34,12c0,0-2-2.5-7-2.5c-9.8,0-18.5,7-18.5,26v5c0,2.2,1.8,4,4,4h9.8c1.7,1.3,3.6,2,5.7,2s4-0.7,5.7-2h9.8	c2.2,0,4-1.8,4-4v-5C47.5,16.5,38.3,12,34,12z"/>
                              <path fill="none" stroke="#18193f" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" stroke-width="3" d="M14.5,19.5c0,0,9.5,0,14-4c0,0,8,1,8,10c-0.5,9.5-5.9,17-12.5,17s-12-7.5-12.5-17"/><path fill="none" stroke="#18193f" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" stroke-width="3" d="M5.6,20.8c-0.7,3-1.1,6.6-1.1,10.7v5c0,2.2,1.8,4,4,4h3.6"/>
                              <path fill="none" stroke="#18193f" stroke-linecap="round" stroke-linejoin="round" stroke-miterlimit="10" stroke-width="3" d="M36.5,40.5h3c2.2,0,4-1.8,4-4v-5C43.5,12.5,34.3,8,30,8c0,0-2-2.5-7-2.5c-5.7,0-11,2.4-14.5,8.1"/><circle cx="19" cy="28" r="2" fill="#18193f"/>
                              <circle cx="29" cy="28" r="2" fill="#18193f"/>
                        </svg>
                        <p class="ml-1 font-bold">{{ `${message.author.firstName} ${message.author.lastName}` }}</p>
                        <p class="absolute top-0 right-0">{{ `${getFormattedDate(message.creationDate.toString())}, ${getFormattedTime(message.creationDate.toString())}` }}</p>
                    </div>
                    <p class="text-gray-600 mt-2">{{ message.text }}</p>

                    <span 
                        style="bottom: calc(100% + 1px)"
                        class=" absolute h-fit w-fit block right-[-1px] max-h-0 overflow-hidden shadow-lg transition-all duration-500 group-hover:max-h-full"
                    >
                        <button 
                            v-if="message.author.id === $store.getters.sub"
                            v-on:click="removeMessage(message.id)"
                            class="m-auto py-[2px] px-[4px] bg-red-500 hover:bg-red-600 shadow-lg flex items-center justify-center rounded-md font-medium">
                            <svg class="fill-white" xmlns="http://www.w3.org/2000/svg"  viewBox="0 0 32 32" width="24px" height="24px">
                                <path d="M 15 4 C 14.476563 4 13.941406 4.183594 13.5625 4.5625 C 13.183594 4.941406 13 5.476563 13 6 L 13 7 L 7 7 L 7 9 L 8 9 L 8 25 C 8 26.644531 9.355469 28 11 28 L 23 28 C 24.644531 28 26 26.644531 26 25 L 26 9 L 27 9 L 27 7 L 21 7 L 21 6 C 21 5.476563 20.816406 4.941406 20.4375 4.5625 C 20.058594 4.183594 19.523438 4 19 4 Z M 15 6 L 19 6 L 19 7 L 15 7 Z M 10 9 L 24 9 L 24 25 C 24 25.554688 23.554688 26 23 26 L 11 26 C 10.445313 26 10 25.554688 10 25 Z M 12 12 L 12 23 L 14 23 L 14 12 Z M 16 12 L 16 23 L 18 23 L 18 12 Z M 20 12 L 20 23 L 22 23 L 22 12 Z"/>
                            </svg>
                        </button>
                    </span>

                </div>
            </div>
            <form 
                v-if="$store.getters.isLoggedIn"
                v-on:submit.prevent="onSubmit"
            >
                <p class="font-bold mb-2">Your reply</p>
                <textarea 
                    v-model="v$.messageText.$model"
                    v-on:blur="v$.messageText.$touch()"
                    v-bind:class="{ 'border-red-500': v$.messageText.$error }"
                    class="w-full bg-gray-100 rounded border border-gray-400 resize-none leading-normal h-auto font-normal focus:outline-none focus:bg-white" 
                    rows="6">
                </textarea>
                <span 
                    v-for="(error, index) in v$.messageText.$errors" :key="index" 
                    class="block text-sm font-semibold text-red-500 float-left"> 
                    {{ error.$message }}
                </span>
                <button type="submit"
                        v-bind:disabled="v$.$invalid"
                        v-bind:class="{ 'cursor-not-allowed': v$.$invalid }" 
                        class="px-3 py-2 bg-yellow-400 hover:bg-yellow-500 rounded-full drop-shadow-md float-right font-bold">
                    Post
                </button>
            </form>
        </div>
    </div>
</template>

<script lang="ts">
    import NavbarComponent from '../components/NavbarComponent.vue'
    import type { ForumMessagesInfoType } from '../types/ForumMessagesInfoType'
    import useVuelidate from '@vuelidate/core'
    import { required } from '@vuelidate/validators'
    import axios from 'axios'

    export default {
        components: {
            NavbarComponent
        },
        props: ['forumId'],
        setup: () => ({ v$: useVuelidate() }),
        data() {
            return {
                forumMessages: undefined as ForumMessagesInfoType | undefined,
                messageText: undefined as string | undefined
            }
        },
        validations() {
            return {
                messageText: { required }
            }
        },
        mounted() {
            this.getMessages()
        },
        methods: {
            async getMessages() {
                try {
                    const response = await axios.get<ForumMessagesInfoType>(`/Forum/${this.$props.forumId}/messages/all`)

                    this.forumMessages = {
                        ...response.data,
                        messages: response.data.messages.map((message) => {
                            return {
                                ...message,
                                creationDate: new Date(message.creationDate),
                                author: { ...message.author }
                            }
                        })
                    }

                } catch(error) {
                    this.$toast.open({
                        message: 'Failed to download the messagew.',
                        type: 'error'
                    })
                }
            },
            handleLogout() {

            },
            getFormattedDate(dateTimeString: string): string {
                const dateTimeObject = new Date(dateTimeString)
                return `${dateTimeObject.getDate().toString().padStart(2, '0')}-${(dateTimeObject.getMonth() + 1).toString().padStart(2, '0')}-${dateTimeObject.getFullYear()}`
            },
            getFormattedTime(dateTimeString: string): string {
                const dateTimeObject = new Date(dateTimeString)
                return `${dateTimeObject.getHours().toString().padStart(2, '0')}:${dateTimeObject.getMinutes().toString().padStart(2, '0')}`
            },
            async onSubmit() {
                this.v$.$validate()
                .then(async () => {
                    try {
                        const response = await axios.put('/Message/', 
                        {
                            text: this.messageText,
                            forumId: this.$props.forumId
                        },
                        {
                            headers: { 'Authorization': `Bearer ${this.$store.getters.token}` }
                        })

                        this.messageText = undefined
                        this.v$.$reset()
                        this.getMessages()

                    } catch(error) {
                        this.$toast.open({
                            message: 'Form is invalid.',
                            type: 'error'
                        })
                    }
                })
                .catch((error) => {

                })
            },
            async removeMessage(messageId: number) {
                try {
                    const response = await axios.delete(`/Message/${messageId}/delete`,
                    {
                        headers: { 'Authorization': `Bearer ${this.$store.getters.token}` }
                    })

                    this.getMessages()

                } catch(error) {
                    this.$toast.open({
                        message: 'Failed to remove message.',
                        type: 'error'
                    })
                }
            }
        }
    }
</script>
