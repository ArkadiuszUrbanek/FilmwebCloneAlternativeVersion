<template>
    <div class="bg-white h-fit w-1/3 rounded-2xl border px-5 py-5">
        <form v-on:submit.prevent="onSubmit">
            <p class="font-bold">Title</p>
            <input 
                type="text"
                v-model="v$.title.$model"
                v-on:blur="v$.title.$touch()"
                v-bind:class="{ 'border-red-500': v$.title.$error }" 
                class="w-full bg-gray-100 rounded border border-gray-400 leading-normal py-2 px-3 font-normal focus:outline-none focus:bg-white"
            >
            <template v-for="(error, index) in v$.title.$errors" :key="index">
                    <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
            </template>
            <p class="font-bold mt-2">Star rating</p>
            <vue3StarRatings 
                v-model="v$.rating.$model"
                v-on:blur="v$.title.$touch()"
                v-bind:starSize="32"
                starColor="#facc15"
                inactiveColor="#333333"
                v-bind:numberOfStars="10"
                v-bind:disableClick="false" 
            />
            <template v-for="(error, index) in v$.rating.$errors" :key="index">
                    <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
            </template>
            <p class="font-bold mt-2">Review</p>
            <textarea 
                v-model="v$.description.$model"
                v-on:blur="v$.description.$touch()"
                v-bind:class="{ 'border-red-500': v$.description.$error }"
                class="w-full bg-gray-100 rounded border border-gray-400 resize-none leading-normal h-auto py-2 px-3 font-normal focus:outline-none focus:bg-white" 
                rows="6">
            </textarea>
            <template v-for="(error, index) in v$.description.$errors" :key="index">
                    <span class="block text-sm font-semibold text-red-500"> {{ error.$message }}</span>
            </template>
            <button
                type="submit"
                v-bind:disabled="v$.$invalid"
                v-bind:class="{ 'cursor-not-allowed': v$.$invalid }" 
                class="px-3 py-2 bg-yellow-400 hover:bg-yellow-500 rounded-full drop-shadow-md float-right font-bold">
                Confirm
            </button>
        </form>
    </div>
</template>

<script lang="ts">
    import { Modal } from "jenesius-vue-modal"
    import vue3StarRatings from "vue3-star-ratings"
    import useVuelidate from '@vuelidate/core'
    import { required, minValue, maxValue } from '@vuelidate/validators'

    export default {
        components: {
            vue3StarRatings
        },
        setup: () => ({ v$: useVuelidate() }),
        data() {
            return {
                title: undefined as string | undefined,
                rating: undefined as number | undefined,
                description: undefined as string | undefined
            }
        },
        validations() {
            return {
                title: { required },
                rating: { required, minValue: minValue(0), maxValue: maxValue(10) },
                description: { required }
            }
        },
        methods: {
            onSubmit() {
                this.v$.$validate()
                .then(() => {
                    this.$emit(Modal.EVENT_PROMPT, {
                        title: this.title,
                        rating: this.rating,
                        description: this.description
                    })
                })
                .catch((error) => {
                    alert('Form data is invalid.')
                })
            }
        }
    }
</script>