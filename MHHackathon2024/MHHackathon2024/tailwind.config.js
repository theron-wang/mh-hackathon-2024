/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./Components/**/*.razor"
    ],
    theme: {
        fontFamily: {
            'main': ["Fira Sans", 'sans-serif']
        },
        extend: {
            colors: {
                theme: 'rgb(17 28 92)'
            }
        },
    },
    plugins: [],
}

