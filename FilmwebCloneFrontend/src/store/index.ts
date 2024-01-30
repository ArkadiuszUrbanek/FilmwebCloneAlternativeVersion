import { createStore } from 'vuex'
import { jwtDecode } from 'jwt-decode'
import type { UserRoleType } from '../types/UserRoleType'
import type { GenderType } from '../types/GenderType'
import type { LoginInfoType } from '../types/LoginInfoType'

const loginInfoStore = createStore<LoginInfoType>({
  state: {
    token: undefined
  } as LoginInfoType,
  mutations: {
    setLoginInfo(state: LoginInfoType, token: string) {
      const decodedToken = jwtDecode<{[key: string]: string}>(token)
      state.sub = +(decodedToken['sub'])
      state.givenName = decodedToken['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname']
      state.surname = decodedToken['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/surname']
      state.email = decodedToken['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress']
      state.gender = decodedToken['http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender'] as GenderType
      state.role = decodedToken['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'] as UserRoleType
      state.token = token
    },
    logOut(state: LoginInfoType) {
      (Object.keys(state) as Array<keyof LoginInfoType>).forEach(key => state[key] = undefined)
    }
  },
  actions: {},
  getters: {
    isLoggedIn(state: LoginInfoType) : boolean {
        return !!state.token
    },
    token(state: LoginInfoType) : string | undefined {
      return state.token
    },
    sub(state: LoginInfoType) : number | undefined {
      return state.sub
    },
    givenName(state: LoginInfoType) : string | undefined {
      return state.surname
    },
    surname(state: LoginInfoType) : string | undefined {
      return state.surname
    },
    email(state: LoginInfoType) : string | undefined {
      return state.email
    },
    gender(state: LoginInfoType) : GenderType | undefined {
      return state.gender
    },
    role(state: LoginInfoType) : UserRoleType | undefined {
      return state.role
    }
  },
})

export default loginInfoStore