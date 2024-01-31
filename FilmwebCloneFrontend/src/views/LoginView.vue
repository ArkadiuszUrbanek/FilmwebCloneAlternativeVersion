<template>
    <div class="flex justify-center items-center h-screen bg-gradient-to-b from-yellow-500 via-red-500 to-pink-500">
        <div class="w-screen max-w-[400px] shadow-lg p-5 rounded bg-white">
            <p class="font-bold text-2xl text-center mt-3 mb-8">Login</p>
            <form class="mb-3" v-on:submit.prevent="onSubmit">
                <label for="email" class="block">Email</label>
                <input
                    type="text"
                    id="email"
                    v-model="v$.email.$model"
                    v-on:blur="v$.email.$touch()"
                    v-bind:class="{ 'border-red-500': v$.email.$error }"
                    placeholder="Type your email"
                    class="border-b-2 pt-3 pb-3 mb-3 w-full focus:outline-none"
                />
                <template v-for="(error, index) in v$.email.$errors" :key="index">
                    <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
                </template>
                <label for="password" class="block">Password</label>
                <input
                    type="password"
                    id="password"
                    v-model="v$.password.$model"
                    v-on:blur="v$.password.$touch()"
                    v-bind:class="{ 'border-red-500': v$.password.$error }"
                    placeholder="Type your password"
                    class="border-b-2 pt-3 pb-3 mb-3 w-full focus:outline-none"
                />
                <template v-for="(error, index) in v$.password.$errors" :key="index">
                    <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
                </template>
                <button
                    type="submit"
                    v-bind:disabled="v$.$invalid"
                    v-bind:class="{ 'cursor-not-allowed': v$.$invalid }"
                    class="block bg-gradient-to-r from-yellow-500 via-red-500 to-pink-500 text-white pt-3 pb-3 pl-6 pr-6 rounded w-full mt-5"
                >
                    LOGIN
                </button>
            </form>
            <router-link to="/signup" class="mt-6 mb-3 text-center block">
                Don't have an account?
            </router-link>
        </div>
    </div>
</template>

<script lang="ts">
    import useVuelidate from '@vuelidate/core'
    import { required, email, minLength } from '@vuelidate/validators'
    import axios from 'axios'

    export default {
        setup: () => ({ v$: useVuelidate() }),
        created () {
            this.lastPath = (this.$router.options.history.state.back as string | undefined)?.split('?')[0]
        },
        data() {
            return {
                nonReturnablePaths: ['/confirm-email', '/signup', '/login'] as string[],
                lastPath: undefined as string | undefined,
                email: '',
                password: ''
            }
        },
        validations() {
            return {
                email: { required, email },
                password: { required, minLength: minLength(6) }
            }
        },
        methods: {
            onSubmit() {
                this.v$.$validate()
                .then(() => {
                    axios.post('Auth/login', {
                        email: this.email,
                        password: this.password
                    })
                    .then((response) => {
                        this.$toast.open({
                            message: 'You are now logged in.',
                            type: 'success'
                        })

                        this.$store.commit('setLoginInfo', response.data)
                        if (!this.lastPath || this.nonReturnablePaths.includes(this.lastPath)) this.$router.push({ path: '/' })
                        else this.$router.push({ path: this.lastPath })
                    })
                    .catch((error) => {
                        this.$toast.open({
                            message: 'Failed to log the user in.',
                            type: 'error'
                        })
                    })
                })
                .catch(() => {
                    this.$toast.open({
                        message: 'Login form is not valid.',
                        type: 'error'
                    })
                })
            }
        }
    }
</script>
