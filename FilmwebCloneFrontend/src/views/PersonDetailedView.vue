<template>
    <div class="flex flex-col h-screen w-screen">
        <navbar-component class="flex-shrink-0"/>
        <div v-if="person" class="bg-white flex items-center justify-center h-full">
            <div class="h-auto w-1/2 p-5 rounded-lg bg-white border shadow-lg">
                <div class="flex h-auto w-full bg-white">
                    <img class="flex-shrink-0 h-[300px] overflow-hidden object-cover rounded" v-bind:src="person.picturePath">
                    <div class="w-full bg-white ml-5">
                        <h1 class="text-3xl font-bold mb-2">{{ `${person.firstName} ${person.lastName}`}}</h1>
                        <p><span class="font-medium">Born: </span>{{ `${getFormattedBirthDateString} ${getFormattedAgeCalculation}`}}</p>
                        <p><span class="font-medium">Nationality: </span>{{ person.nationality }} <flag :iso="translatePersonNationalityTypeToISO" :squared="false"/></p>
                        <p><span class="font-medium">Height: </span>{{ person.height }} [cm]</p>
                    </div>
                </div>
                <p class="text-justify mt-5">{{ person.description }}</p>
            </div>
        </div>
    </div>
</template>

<script lang="ts">
    import type { PersonDetailedInfoType } from '../types/PersonDetailedInfoType'
    import NavbarComponent from '../components/NavbarComponent.vue'
    import axios from 'axios'

    export default {
        components: {
            NavbarComponent
        },
        props: ['personId'],
        data() {
            return {
                person: undefined as PersonDetailedInfoType | undefined
            }
        },
        mounted() {
            this.getPerson()
        },
        methods: {
            async getPerson() {
                try {
                    const response = await axios.get<PersonDetailedInfoType>(`/Person/${this.$props.personId}`)

                    this.person = {
                        ...response.data,
                        birthDate: new Date(response.data.birthDate.toString() + 'T00:00:00.000Z')
                    }

                } catch(error) {
                    this.$toast.open({
                        message: 'Failed to download the actor\'s information.',
                        type: 'error'
                    })
                }
            }
        },
        computed: {
            getFormattedBirthDateString(): string {
                const months = [
                  'January', 'February', 'March', 'April', 'May', 'June', 'July',
                  'August', 'September', 'October', 'November', 'December'
                ]

                const day = this.person!.birthDate.getUTCDate()
                const monthName = months[this.person!.birthDate.getUTCMonth()]
                const year = this.person!.birthDate.getUTCFullYear()

                function getDayWithSuffix(day: number): string {
                    if (day >= 11 && day <= 13) return day + 'th'
                  
                    switch (day % 10) {
                        case 1: return day + 'st'
                        case 2: return day + 'nd'
                        case 3: return day + 'rd'
                        default: return day + 'th'
                    }
                }
            
                return `${getDayWithSuffix(day)} ${monthName} ${year}`
            },
            getFormattedAgeCalculation(): string {
                const calculateAge = () => {
                    const today = new Date()
                    const birthDateObj = new Date(this.person!.birthDate)
                    let age = today.getUTCFullYear() - birthDateObj.getUTCFullYear()
                            
                    const todayMonth = today.getUTCMonth()
                    const birthDateMonth = birthDateObj.getUTCMonth()
                            
                    if (todayMonth < birthDateMonth || (todayMonth === birthDateMonth && today.getUTCDate() < birthDateObj.getUTCDate())) age--
                    return age
                }
            
                const age = calculateAge()

                function getYearWithSuffix(age: number): string {
                  return age === 1 ? 'year' : 'years'
                }
            
                return `(${age} ${getYearWithSuffix(age)} old)`
            },
            translatePersonNationalityTypeToISO(): string {
              const nationalityMap = {
                    American: 'US',
                    Scottish: 'GB',
                    English: 'GB',
                    Canadian: 'CA',
                    Welsh: 'GB',
                    Australian: 'AU',
                }

                return nationalityMap[this.person!.nationality] || 'N/A'
            },
        }
    }
</script>