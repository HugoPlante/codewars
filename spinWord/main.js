function spinWords(string) {
    const wordsArray = string.split(' ');
    let reversedSentence = "";

    wordsArray.map((word) => {
        let newWord = "";
        newWord = (word.length >= 5) ? word.split('').reverse().join('').trim() : word;
        reversedSentence = [reversedSentence, newWord].join('');
    })
    return reversedSentence.trim();
}