import axios from 'axios';

const httpService = (baseUrl, sessionInfo) => {

    const headers = {
        'Content-type': 'application/json',
    }
    
    const header = {...headers,  Authorization: `Bearer ${sessionInfo.token}`}
    return {
        get : async(url, options = {}) => axios.get(baseUrl+url, {headers: {...header, ...options}}),
        post: async(url, data, options = {}) => axios.post(baseUrl+url, data, { headers: {...header, ...options}})

    }
    
}

export default httpService;

