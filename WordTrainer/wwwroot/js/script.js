

 class Word {
     constructor(wordID, text, rank, translation, transcription, isForgoten, favourite, examples) {
        this.wordID = wordID;
        this.text = text;
        this.rank = rank;
        this.translation = translation;
        this.transcription = transcription;
        this.isForgoten = isForgoten;
        this.favourite = favourite;
        this.examples = examples;
    }

    parse(wordObject) {
        this.wordID = wordObject['wordID'];
        this.text = wordObject['text'];
        this.rank = wordObject['rank'];
        this.translation = wordObject['translation'];
        this.transcription = wordObject['transcription'];
        this.isForgoten = wordObject['isForgoten'];
        this.favourite = wordObject['favourite'];
        this.examples = wordObject['examples'];
    }

    static parse(wordObject) {
        var temp = new Word();
        temp.wordID = wordObject['wordID'];
        temp.text = wordObject['text'];
        temp.rank = wordObject['rank'];
        temp.transcription = wordObject['transcription'];
        temp.translation = wordObject['translation'];
        temp.isForgoten = wordObject['isForgoten'];
        temp.favourite = wordObject['favourite'];
        temp.examples = wordObject['examples'];
        return temp;
    }
}

export {Word}


