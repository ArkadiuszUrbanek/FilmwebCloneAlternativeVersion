<template>
    <div class="px-10 bg-amber-400 shadow-lg">
        <div class="relative pt-6 pb-6">
            <nav class="relative flex items-center justify-between sm:h-10 md:justify-center">
                <div class="flex items-center flex-1 md:absolute md:inset-y-0 md:left-0">
                    <router-link to="/">
                        <img class="w-auto h-8 sm:h-10" src="../assets/logo.png" loading="lazy" width="202" height="40">
                    </router-link>
                </div>
                <div class="hidden md:flex md:space-x-10 list-none">
                    <li>
                        <router-link to="/" class="text-base font-bold text-black list-none">Home</router-link>
                    </li>
                    <li>
                        <router-link to="/forum" class="text-base font-bold text-black list-none">Forum</router-link>
                    </li>
                </div>
                <div class="hidden md:absolute md:flex md:items-center md:justify-end md:inset-y-0 md:right-0">
                    <div class="relative parent">
                        <div class="p-1 rounded-full border-black border-solid border-2">
                            <svg class="w-6 h-6" viewBox="0 0 24 24" fill="none" xmlns="http://www.w3.org/2000/svg">
                                <path 
                                    d="M5 21C5 17.134 8.13401 14 12 14C15.866 14 19 17.134 19 21M16 7C16 9.20914 14.2091 11 12 11C9.79086 11 8 9.20914 8 7C8 4.79086 9.79086 3 12 3C14.2091 3 16 4.79086 16 7Z" 
                                    stroke="#000000" 
                                    stroke-width="2" 
                                    stroke-linecap="round" 
                                    stroke-linejoin="round"
                                />
                            </svg>
                        </div>
                        <ul class="child transition duration-300 md:absolute top-full right-0 whitespace-nowrap bg-white md:shadow-lg md:rounded-b">
                            <template v-if="!$store.getters.isLoggedIn">
                                <li>
                                    <router-link to="/signup" class="flex px-4 py-3 hover:bg-gray-50">Sign up</router-link>
                                </li>
                                <li>
                                    <router-link to="/login" class="flex px-4 py-3 hover:bg-gray-50">Log in</router-link>
                                </li>
                            </template>
                            <template v-else>
                                <li>
                                    <button 
                                        v-on:click="onLogoutButtonClick" 
                                        class="flex px-4 py-3 hover:bg-gray-50"
                                    >
                                        Log out
                                    </button>
                                </li>
                            </template>
                        </ul>
                    </div>
                </div>
            </nav>
        </div>
    </div>
</template>

<script lang="ts">
    export default {
        data() {
            return {

            }
        },
        methods: {
            onLogoutButtonClick() {
                this.$store.commit('logOut')
                this.$emit('logOut')
            }
        }
    }
</script>

<style scoped>
.parent:hover .child {
    opacity:1;
    height:auto;
    overflow:none;
    transform: translateY(0);
}

.child {
    opacity:0;
    height:0;
    overflow:hidden;
    transform: translateY(-10%);
}
</style>