import { createRouter, createWebHistory } from 'vue-router'
import LoginView from '../views/LoginView.vue'
import HomeView from '../views/HomeView.vue'
import loginInfoStore from '../store'
import { type UserRoleType } from '../types/UserRoleType'
import SignupView from '../views/SignupView.vue'
import EmailConfirmationView from '../views/EmailConfirmationView.vue'
import FilmDetailedView from '../views/FilmDetailedView.vue'
import PersonDetailedView from '../views/PersonDetailedView.vue'
import ForumView from '../views/ForumView.vue'
import ForumMessagesView from '../views/ForumMessagesView.vue'

type MetaData = {
  requiresAuthentication: boolean
  requiresAuthorization: boolean
  authorizedRoles?: UserRoleType[]
}

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      component: HomeView,
      meta: {
        requiresAuthentication: false,
        requiresAuthorization: false,
      } as MetaData
    },
    {
      path: '/login',
      component: LoginView,
      meta: {
        requiresAuthentication: false,
        requiresAuthorization: false
      } as MetaData
    },
    {
      path: '/signup',
      component: SignupView,
      meta: {
        requiresAuthentication: false,
        requiresAuthorization: false
      } as MetaData
    },
    {
      path: '/confirm-email',
      component: EmailConfirmationView,
      meta: {
        requiresAuthentication: false,
        requiresAuthorization: false
      } as MetaData
    },
    {
      path: '/film/:filmId/details',
      props: true,
      name: 'film-details',
      component: FilmDetailedView,
      meta: {
        requiresAuthentication: false,
        requiresAuthorization: false
      } as MetaData
    },
    {
      path: '/person/:personId/details',
      props: true,
      name: 'person-details',
      component: PersonDetailedView,
      meta: {
        requiresAuthentication: false,
        requiresAuthorization: false
      } as MetaData
    },
    {
      path: '/forum',
      component: ForumView,
      meta: {
        requiresAuthentication: false,
        requiresAuthorization: false
      } as MetaData
    },
    {
      path: '/forum/:forumId/messages',
      props: true,
      name: 'forum-messages',
      component: ForumMessagesView,
      meta: {
        requiresAuthentication: false,
        requiresAuthorization: false
      } as MetaData
    }
  ]
})

router.beforeEach((to, from, next) => {
  if (!(to.meta.requiresAuthentication as boolean)) {
    next()
    return
  }

  if (loginInfoStore.getters.isLoggedIn) {
    if (!(to.meta.requiresAuthorization as boolean)) {
      next()
      return
    }
    
    if((to.meta.authorizedRoles as UserRoleType[]).includes(loginInfoStore.getters.role)) {
      next()
      return
    }
  }
})

export default router
