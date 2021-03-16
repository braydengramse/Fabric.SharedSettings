module.exports = {
    env: {
        browser: true,
        es6: true,
        node: true
    },
    parser: '@typescript-eslint/parser',
    plugins: ['@angular-eslint', '@typescript-eslint'],
    extends: ['eslint:recommended', 'plugin:@typescript-eslint/recommended', 'prettier'],
    rules: {
        '@angular-eslint/component-selector': [
            'error',
            {
                type: 'element',
				// this should be changed to your application's prefix
                prefix: 'lw',
                style: 'kebab-case'
            }
        ],
        '@angular-eslint/directive-selector': [
            'error',
            {
                type: 'attribute',
				// this should be changed to your application's prefix
                prefix: 'lw',
                style: 'camelCase'
            }
        ]
    }
};
