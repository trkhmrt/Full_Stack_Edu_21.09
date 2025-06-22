import axios from 'axios'

const apiUrl = "http://localhost:5264"

export const CategoryService = {
    getAllCategories: async () => {return await axios.get(`${apiUrl}/Category/getAllCategories/`)},
}