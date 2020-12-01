export const GetMessages = (elem) => {
    const messages = [];
    if (elem.validity.valueMissing) {
        messages.push("   Поле не заполнено");
    }
    if (elem.validity.typeMismatch) {
        messages.push(`Invalid ${elem.type}`);
    }
    return messages;
}