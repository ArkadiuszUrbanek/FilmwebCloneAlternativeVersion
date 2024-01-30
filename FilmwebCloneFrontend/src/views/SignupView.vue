<template>
    <div class="flex justify-center items-center h-screen bg-gradient-to-b from-yellow-500 via-red-500 to-pink-500">
        <div class="w-screen max-w-[400px] shadow-lg p-5 rounded bg-white">
            <p class="font-bold text-2xl text-center mt-3 mb-8">Signup</p>
            <form @submit.prevent="onSubmit">
                <div class="mb-3">
                    <label for="firstName" class="block">Firstname</label>
                    <input
                        type="text"
                        id="firstName"
                        v-model="v$.firstName.$model"
                        v-on:blur="v$.firstName.$touch()"
                        v-bind:class="{ 'border-red-500': v$.firstName.$error }"
                        placeholder="Type your username"
                        class="border-b-2 pt-3 pb-3 mb-3 w-full focus:outline-none"
                    />
                    <template v-for="(error, index) in v$.firstName.$errors" :key="index">
                        <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
                    </template>
                </div>
                <div class="mb-3">
                    <label for="lastName" class="block">Lastname</label>
                    <input
                        type="text"
                        id="lastName"
                        v-model="v$.lastName.$model"
                        v-on:blur="v$.lastName.$touch()"
                        v-bind:class="{ 'border-red-500': v$.lastName.$error }"
                        placeholder="Type your name"
                        class="border-b-2 pt-3 pb-3 mb-3 w-full focus:outline-none"
                    />
                    <template v-for="(error, index) in v$.lastName.$errors" :key="index">
                        <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
                    </template>
                </div>
                <div class="mb-3">
                    <label class="block">Gender</label>
                    <div class="flex">
                        <input 
                            type="radio" 
                            id="genderMale"
                            v-model="v$.gender.$model"
                            v-on:blur="v$.gender.$touch()" 
                            v-bind:class="{ 'border-red-500': v$.gender.$error }"
                            value="Male"/>
                        <label for="genderMale" class="ml-1">Male</label>
                        <input 
                            type="radio" 
                            id="genderFemale" 
                            v-model="v$.gender.$model" 
                            v-on:blur="v$.gender.$touch()"
                            v-bind:class="{ 'border-red-500': v$.gender.$error }"
                            class="ml-2" 
                            value="Female"
                        />
                        <label for="genderFemale" class="ml-1">Female</label>
                    </div>
                    <template v-for="(error, index) in v$.gender.$errors" :key="index">
                        <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
                    </template>
                </div>
                <div class="mb-3">
                    <label for="birthDate" class="block">Birth Date</label>
                    <input
                        type="date"
                        id="birthDate"
                        v-model="v$.birthDate.$model"
                        v-on:blur="v$.birthDate.$touch()"
                        v-bind:class="{ 'border-red-500': v$.birthDate.$error }"
                        class="border-b-2 pt-3 pb-3 mb-3 w-full focus:outline-none"
                    />
                    <template v-for="(error, index) in v$.birthDate.$errors" :key="index">
                        <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
                    </template>
                </div>
                <div>
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
                </div>
                <div>
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
                </div>
                <div>
                    <label for="confirmPassword" class="block">Confirm password</label>
                    <input
                        type="password"
                        id="confirmPassword"
                        v-model="v$.confirmPassword.$model"
                        v-on:blur="v$.confirmPassword.$touch()"
                        v-bind:class="{ 'border-red-500': v$.confirmPassword.$error }"
                        placeholder="Retype your password"
                        class="border-b-2 pt-3 pb-3 mb-3 w-full focus:outline-none"
                    />
                    <template v-for="(error, index) in v$.confirmPassword.$errors" :key="index">
                        <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
                    </template>
                </div>
                <button
                    type="submit"
                    v-bind:disabled="v$.$invalid"
                    v-bind:class="{ 'cursor-not-allowed': v$.$invalid }"
                    class="block bg-gradient-to-r from-yellow-500 via-red-500 to-pink-500 text-white pt-3 pb-3 pl-6 pr-6 rounded w-full mt-5"
                >
                    Signup
                </button>
            </form>
            <router-link to="/login" class="mt-6 mb-3 text-center block">
                Already have an account?
            </router-link>
        </div>
    </div>
</template>

<script lang="ts">
    import useVuelidate from '@vuelidate/core'
    import { required, email, minLength, sameAs, helpers } from '@vuelidate/validators'
    import axios from 'axios'
    import { type GenderType } from '../types/GenderType'

    export default {
        setup: () => ({ v$: useVuelidate() }),
        data() {
            return {
                firstName: '',
                lastName: '',
                gender: '' as GenderType,
                birthDate: '',
                email: '',
                password: '',
                confirmPassword: ''
            }
        },
        validations() {
            return {
                firstName: { required },
                lastName: { required },
                gender: { required },
                birthDate: { 
                    required, 
                    minAge: helpers.withMessage('You have to be at least 18 years old',
                    (value: string) => {
                        const today = new Date()
                        const birthDate = new Date(value)
                        let yearDiff = today.getFullYear() - birthDate.getFullYear()
                        const monthDiff = today.getMonth() - birthDate.getMonth()
                        
                        if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < birthDate.getDate())) yearDiff--
                        
                        if (yearDiff >= 18) return true
                        
                        return false
                    })
                },
                email: { required, email },
                password: { required, minLength: minLength(6) },
                confirmPassword: { 
                    required, 
                    minLength: minLength(6), 
                    sameAs: helpers.withMessage('Given passwords do not match', sameAs(this.password)) 
                }
            }
        },
        methods: {
            onSubmit() {
                this.v$.$validate()
                .then(() => {
                    axios.post('Auth/register', {
                        firstName: this.firstName,
                        lastName: this.lastName,
                        gender: this.gender,
                        birthDate: this.birthDate,
                        email: this.email,
                        password: this.password
                    })
                    .then((response) => {
                        this.$toast.open({
                            message: 'Verification link has been sent.',
                            type: 'success'
                        })
                        this.$router.push('/')
                    })
                    .catch((error) => {
                        this.$toast.open({
                            message: 'Failed to register the user.',
                            type: 'error'
                        })
                    })
                })
                .catch(() => {
                    this.$toast.open({
                        message: 'Registration form is invalid.',
                        type: 'error'
                    })
                })
            }
        }
    }
</script>../types/GenderType