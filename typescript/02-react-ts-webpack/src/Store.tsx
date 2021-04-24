import { useReducer, createContext } from 'react'
import { IState, IAction } from './types/interfaces'
const initialState: IState = {
  episodes: [],
  favourites: []
}
export const Store = createContext(initialState)
const reducer = (state: IState, action: IAction): IState => {
  switch (action.type) {
    case 'FETCH_DATA':
      return { ...state, episodes: action.payload }
    default:
      return state
  }
}
export const StoreProvider = ({ children }: JSX.ElementChildrenAttribute): JSX.Element => {
  const [state, dispatch] = useReducer(reducer, initialState)
  return {children}
}
