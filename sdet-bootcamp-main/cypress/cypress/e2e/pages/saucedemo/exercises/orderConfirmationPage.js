class OrderConfirmationPage {

    sendOrderConfirmation()
    {
        cy.get('h2.complete-header')
            .should('be.visible')
            .should('have.text', 'Thank you for your order!')
    }
}

export default OrderConfirmationPage