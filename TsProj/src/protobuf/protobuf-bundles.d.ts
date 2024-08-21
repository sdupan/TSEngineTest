type Long = protobuf.Long;
// DO NOT EDIT! This is a generated file. Edit the JSDoc in src/*.js instead and run 'npm run types'.

/** Namespace actdice. */
declare namespace actdice {

    /** Properties of a GRID. */
    interface IGRID {

        /** GRID level */
        level?: (number|null);

        /** GRID reward_id */
        reward_id?: (number|null);
    }

    /** Represents a GRID. */
    class GRID implements IGRID {

        /**
         * Constructs a new GRID.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IGRID);

        /** GRID level. */
        public level: number;

        /** GRID reward_id. */
        public reward_id: number;

        /**
         * Creates a new GRID instance using the specified properties.
         * @param [properties] Properties to set
         * @returns GRID instance
         */
        public static create(properties?: actdice.IGRID): actdice.GRID;

        /**
         * Encodes the specified GRID message. Does not implicitly {@link actdice.GRID.verify|verify} messages.
         * @param message GRID message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IGRID, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified GRID message, length delimited. Does not implicitly {@link actdice.GRID.verify|verify} messages.
         * @param message GRID message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IGRID, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a GRID message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns GRID
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.GRID;

        /**
         * Decodes a GRID message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns GRID
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.GRID;

        /**
         * Verifies a GRID message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a GIFT. */
    interface IGIFT {

        /** GIFT count */
        count?: (number|null);
    }

    /** Represents a GIFT. */
    class GIFT implements IGIFT {

        /**
         * Constructs a new GIFT.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IGIFT);

        /** GIFT count. */
        public count: number;

        /**
         * Creates a new GIFT instance using the specified properties.
         * @param [properties] Properties to set
         * @returns GIFT instance
         */
        public static create(properties?: actdice.IGIFT): actdice.GIFT;

        /**
         * Encodes the specified GIFT message. Does not implicitly {@link actdice.GIFT.verify|verify} messages.
         * @param message GIFT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IGIFT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified GIFT message, length delimited. Does not implicitly {@link actdice.GIFT.verify|verify} messages.
         * @param message GIFT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IGIFT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a GIFT message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns GIFT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.GIFT;

        /**
         * Decodes a GIFT message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns GIFT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.GIFT;

        /**
         * Verifies a GIFT message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a RES. */
    interface IRES {

        /** RES count */
        count?: (number|null);
    }

    /** Represents a RES. */
    class RES implements IRES {

        /**
         * Constructs a new RES.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IRES);

        /** RES count. */
        public count: number;

        /**
         * Creates a new RES instance using the specified properties.
         * @param [properties] Properties to set
         * @returns RES instance
         */
        public static create(properties?: actdice.IRES): actdice.RES;

        /**
         * Encodes the specified RES message. Does not implicitly {@link actdice.RES.verify|verify} messages.
         * @param message RES message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IRES, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified RES message, length delimited. Does not implicitly {@link actdice.RES.verify|verify} messages.
         * @param message RES message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IRES, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a RES message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns RES
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.RES;

        /**
         * Decodes a RES message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns RES
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.RES;

        /**
         * Verifies a RES message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO score */
        score?: (string|null);

        /** G_INFO grid_id */
        grid_id?: (number|null);

        /** G_INFO grids */
        grids?: ({ [k: string]: actdice.IGRID }|null);

        /** G_INFO res */
        res?: ({ [k: string]: actdice.IRES }|null);

        /** G_INFO last_recover_time */
        last_recover_time?: (number|Long|null);

        /** G_INFO prison_count */
        prison_count?: (number|null);

        /** G_INFO gifts */
        gifts?: ({ [k: string]: actdice.IGIFT }|null);

        /** G_INFO reward_state */
        reward_state?: (boolean|null);

        /** G_INFO reward_state_id */
        reward_state_id?: (number|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IG_INFO);

        /** G_INFO score. */
        public score: string;

        /** G_INFO grid_id. */
        public grid_id: number;

        /** G_INFO grids. */
        public grids: { [k: string]: actdice.IGRID };

        /** G_INFO res. */
        public res: { [k: string]: actdice.IRES };

        /** G_INFO last_recover_time. */
        public last_recover_time: (number|Long);

        /** G_INFO prison_count. */
        public prison_count: number;

        /** G_INFO gifts. */
        public gifts: { [k: string]: actdice.IGIFT };

        /** G_INFO reward_state. */
        public reward_state: boolean;

        /** G_INFO reward_state_id. */
        public reward_state_id: number;

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: actdice.IG_INFO): actdice.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link actdice.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link actdice.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_INIT_GRID_REWARD. */
    interface IU_INIT_GRID_REWARD {

        /** U_INIT_GRID_REWARD rewards */
        rewards?: ({ [k: string]: number }|null);
    }

    /** Represents a U_INIT_GRID_REWARD. */
    class U_INIT_GRID_REWARD implements IU_INIT_GRID_REWARD {

        /**
         * Constructs a new U_INIT_GRID_REWARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IU_INIT_GRID_REWARD);

        /** U_INIT_GRID_REWARD rewards. */
        public rewards: { [k: string]: number };

        /**
         * Creates a new U_INIT_GRID_REWARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_INIT_GRID_REWARD instance
         */
        public static create(properties?: actdice.IU_INIT_GRID_REWARD): actdice.U_INIT_GRID_REWARD;

        /**
         * Encodes the specified U_INIT_GRID_REWARD message. Does not implicitly {@link actdice.U_INIT_GRID_REWARD.verify|verify} messages.
         * @param message U_INIT_GRID_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IU_INIT_GRID_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_INIT_GRID_REWARD message, length delimited. Does not implicitly {@link actdice.U_INIT_GRID_REWARD.verify|verify} messages.
         * @param message U_INIT_GRID_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IU_INIT_GRID_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_INIT_GRID_REWARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_INIT_GRID_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.U_INIT_GRID_REWARD;

        /**
         * Decodes a U_INIT_GRID_REWARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_INIT_GRID_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.U_INIT_GRID_REWARD;

        /**
         * Verifies a U_INIT_GRID_REWARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_TURN. */
    interface IU_TURN {

        /** U_TURN grids */
        grids?: (number[]|null);

        /** U_TURN rate */
        rate?: (number|null);

        /** U_TURN prison_count */
        prison_count?: (number|null);
    }

    /** Represents a U_TURN. */
    class U_TURN implements IU_TURN {

        /**
         * Constructs a new U_TURN.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IU_TURN);

        /** U_TURN grids. */
        public grids: number[];

        /** U_TURN rate. */
        public rate: number;

        /** U_TURN prison_count. */
        public prison_count: number;

        /**
         * Creates a new U_TURN instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_TURN instance
         */
        public static create(properties?: actdice.IU_TURN): actdice.U_TURN;

        /**
         * Encodes the specified U_TURN message. Does not implicitly {@link actdice.U_TURN.verify|verify} messages.
         * @param message U_TURN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IU_TURN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_TURN message, length delimited. Does not implicitly {@link actdice.U_TURN.verify|verify} messages.
         * @param message U_TURN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IU_TURN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_TURN message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_TURN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.U_TURN;

        /**
         * Decodes a U_TURN message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_TURN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.U_TURN;

        /**
         * Verifies a U_TURN message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_BOSS_ATTACK. */
    interface IU_BOSS_ATTACK {

        /** U_BOSS_ATTACK grids */
        grids?: (number[]|null);
    }

    /** Represents a U_BOSS_ATTACK. */
    class U_BOSS_ATTACK implements IU_BOSS_ATTACK {

        /**
         * Constructs a new U_BOSS_ATTACK.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IU_BOSS_ATTACK);

        /** U_BOSS_ATTACK grids. */
        public grids: number[];

        /**
         * Creates a new U_BOSS_ATTACK instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_BOSS_ATTACK instance
         */
        public static create(properties?: actdice.IU_BOSS_ATTACK): actdice.U_BOSS_ATTACK;

        /**
         * Encodes the specified U_BOSS_ATTACK message. Does not implicitly {@link actdice.U_BOSS_ATTACK.verify|verify} messages.
         * @param message U_BOSS_ATTACK message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IU_BOSS_ATTACK, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_BOSS_ATTACK message, length delimited. Does not implicitly {@link actdice.U_BOSS_ATTACK.verify|verify} messages.
         * @param message U_BOSS_ATTACK message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IU_BOSS_ATTACK, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_BOSS_ATTACK message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_BOSS_ATTACK
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.U_BOSS_ATTACK;

        /**
         * Decodes a U_BOSS_ATTACK message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_BOSS_ATTACK
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.U_BOSS_ATTACK;

        /**
         * Verifies a U_BOSS_ATTACK message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_SYNC_SCORE. */
    interface IU_SYNC_SCORE {

        /** U_SYNC_SCORE score */
        score?: (string|null);
    }

    /** Represents a U_SYNC_SCORE. */
    class U_SYNC_SCORE implements IU_SYNC_SCORE {

        /**
         * Constructs a new U_SYNC_SCORE.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IU_SYNC_SCORE);

        /** U_SYNC_SCORE score. */
        public score: string;

        /**
         * Creates a new U_SYNC_SCORE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_SYNC_SCORE instance
         */
        public static create(properties?: actdice.IU_SYNC_SCORE): actdice.U_SYNC_SCORE;

        /**
         * Encodes the specified U_SYNC_SCORE message. Does not implicitly {@link actdice.U_SYNC_SCORE.verify|verify} messages.
         * @param message U_SYNC_SCORE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IU_SYNC_SCORE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_SYNC_SCORE message, length delimited. Does not implicitly {@link actdice.U_SYNC_SCORE.verify|verify} messages.
         * @param message U_SYNC_SCORE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IU_SYNC_SCORE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_SYNC_SCORE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_SYNC_SCORE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.U_SYNC_SCORE;

        /**
         * Decodes a U_SYNC_SCORE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_SYNC_SCORE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.U_SYNC_SCORE;

        /**
         * Verifies a U_SYNC_SCORE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_REFRESH_GRID_REWARD. */
    interface IU_REFRESH_GRID_REWARD {

        /** U_REFRESH_GRID_REWARD rewards */
        rewards?: ({ [k: string]: number }|null);
    }

    /** Represents a U_REFRESH_GRID_REWARD. */
    class U_REFRESH_GRID_REWARD implements IU_REFRESH_GRID_REWARD {

        /**
         * Constructs a new U_REFRESH_GRID_REWARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IU_REFRESH_GRID_REWARD);

        /** U_REFRESH_GRID_REWARD rewards. */
        public rewards: { [k: string]: number };

        /**
         * Creates a new U_REFRESH_GRID_REWARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_REFRESH_GRID_REWARD instance
         */
        public static create(properties?: actdice.IU_REFRESH_GRID_REWARD): actdice.U_REFRESH_GRID_REWARD;

        /**
         * Encodes the specified U_REFRESH_GRID_REWARD message. Does not implicitly {@link actdice.U_REFRESH_GRID_REWARD.verify|verify} messages.
         * @param message U_REFRESH_GRID_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IU_REFRESH_GRID_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_REFRESH_GRID_REWARD message, length delimited. Does not implicitly {@link actdice.U_REFRESH_GRID_REWARD.verify|verify} messages.
         * @param message U_REFRESH_GRID_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IU_REFRESH_GRID_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_REFRESH_GRID_REWARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_REFRESH_GRID_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.U_REFRESH_GRID_REWARD;

        /**
         * Decodes a U_REFRESH_GRID_REWARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_REFRESH_GRID_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.U_REFRESH_GRID_REWARD;

        /**
         * Verifies a U_REFRESH_GRID_REWARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_BUY_SHOP. */
    interface IU_BUY_SHOP {

        /** U_BUY_SHOP buy_id */
        buy_id?: (number|null);
    }

    /** Represents a U_BUY_SHOP. */
    class U_BUY_SHOP implements IU_BUY_SHOP {

        /**
         * Constructs a new U_BUY_SHOP.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IU_BUY_SHOP);

        /** U_BUY_SHOP buy_id. */
        public buy_id: number;

        /**
         * Creates a new U_BUY_SHOP instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_BUY_SHOP instance
         */
        public static create(properties?: actdice.IU_BUY_SHOP): actdice.U_BUY_SHOP;

        /**
         * Encodes the specified U_BUY_SHOP message. Does not implicitly {@link actdice.U_BUY_SHOP.verify|verify} messages.
         * @param message U_BUY_SHOP message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IU_BUY_SHOP, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_BUY_SHOP message, length delimited. Does not implicitly {@link actdice.U_BUY_SHOP.verify|verify} messages.
         * @param message U_BUY_SHOP message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IU_BUY_SHOP, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_BUY_SHOP message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_BUY_SHOP
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.U_BUY_SHOP;

        /**
         * Decodes a U_BUY_SHOP message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_BUY_SHOP
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.U_BUY_SHOP;

        /**
         * Verifies a U_BUY_SHOP message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_REWARD. */
    interface IU_REWARD {

        /** U_REWARD stage */
        stage?: (number|null);
    }

    /** Represents a U_REWARD. */
    class U_REWARD implements IU_REWARD {

        /**
         * Constructs a new U_REWARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IU_REWARD);

        /** U_REWARD stage. */
        public stage: number;

        /**
         * Creates a new U_REWARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_REWARD instance
         */
        public static create(properties?: actdice.IU_REWARD): actdice.U_REWARD;

        /**
         * Encodes the specified U_REWARD message. Does not implicitly {@link actdice.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_REWARD message, length delimited. Does not implicitly {@link actdice.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.U_REWARD;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.U_REWARD;

        /**
         * Verifies a U_REWARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_DICE_RECOVER. */
    interface IU_DICE_RECOVER {

        /** U_DICE_RECOVER is_stop */
        is_stop?: (boolean|null);

        /** U_DICE_RECOVER time */
        time?: (number|Long|null);

        /** U_DICE_RECOVER recover_count */
        recover_count?: (number|null);
    }

    /** Represents a U_DICE_RECOVER. */
    class U_DICE_RECOVER implements IU_DICE_RECOVER {

        /**
         * Constructs a new U_DICE_RECOVER.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IU_DICE_RECOVER);

        /** U_DICE_RECOVER is_stop. */
        public is_stop: boolean;

        /** U_DICE_RECOVER time. */
        public time: (number|Long);

        /** U_DICE_RECOVER recover_count. */
        public recover_count: number;

        /**
         * Creates a new U_DICE_RECOVER instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_DICE_RECOVER instance
         */
        public static create(properties?: actdice.IU_DICE_RECOVER): actdice.U_DICE_RECOVER;

        /**
         * Encodes the specified U_DICE_RECOVER message. Does not implicitly {@link actdice.U_DICE_RECOVER.verify|verify} messages.
         * @param message U_DICE_RECOVER message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IU_DICE_RECOVER, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_DICE_RECOVER message, length delimited. Does not implicitly {@link actdice.U_DICE_RECOVER.verify|verify} messages.
         * @param message U_DICE_RECOVER message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IU_DICE_RECOVER, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_DICE_RECOVER message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_DICE_RECOVER
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.U_DICE_RECOVER;

        /**
         * Decodes a U_DICE_RECOVER message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_DICE_RECOVER
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.U_DICE_RECOVER;

        /**
         * Verifies a U_DICE_RECOVER message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_SYNC_STAGE. */
    interface IU_SYNC_STAGE {

        /** U_SYNC_STAGE stage */
        stage?: (number|null);
    }

    /** Represents a U_SYNC_STAGE. */
    class U_SYNC_STAGE implements IU_SYNC_STAGE {

        /**
         * Constructs a new U_SYNC_STAGE.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IU_SYNC_STAGE);

        /** U_SYNC_STAGE stage. */
        public stage: number;

        /**
         * Creates a new U_SYNC_STAGE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_SYNC_STAGE instance
         */
        public static create(properties?: actdice.IU_SYNC_STAGE): actdice.U_SYNC_STAGE;

        /**
         * Encodes the specified U_SYNC_STAGE message. Does not implicitly {@link actdice.U_SYNC_STAGE.verify|verify} messages.
         * @param message U_SYNC_STAGE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IU_SYNC_STAGE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_SYNC_STAGE message, length delimited. Does not implicitly {@link actdice.U_SYNC_STAGE.verify|verify} messages.
         * @param message U_SYNC_STAGE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IU_SYNC_STAGE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_SYNC_STAGE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_SYNC_STAGE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.U_SYNC_STAGE;

        /**
         * Decodes a U_SYNC_STAGE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_SYNC_STAGE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.U_SYNC_STAGE;

        /**
         * Verifies a U_SYNC_STAGE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_STAGE_REWARD. */
    interface IU_STAGE_REWARD {

        /** U_STAGE_REWARD stage */
        stage?: (number|null);
    }

    /** Represents a U_STAGE_REWARD. */
    class U_STAGE_REWARD implements IU_STAGE_REWARD {

        /**
         * Constructs a new U_STAGE_REWARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: actdice.IU_STAGE_REWARD);

        /** U_STAGE_REWARD stage. */
        public stage: number;

        /**
         * Creates a new U_STAGE_REWARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_STAGE_REWARD instance
         */
        public static create(properties?: actdice.IU_STAGE_REWARD): actdice.U_STAGE_REWARD;

        /**
         * Encodes the specified U_STAGE_REWARD message. Does not implicitly {@link actdice.U_STAGE_REWARD.verify|verify} messages.
         * @param message U_STAGE_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: actdice.IU_STAGE_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_STAGE_REWARD message, length delimited. Does not implicitly {@link actdice.U_STAGE_REWARD.verify|verify} messages.
         * @param message U_STAGE_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: actdice.IU_STAGE_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_STAGE_REWARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_STAGE_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): actdice.U_STAGE_REWARD;

        /**
         * Decodes a U_STAGE_REWARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_STAGE_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): actdice.U_STAGE_REWARD;

        /**
         * Verifies a U_STAGE_REWARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace activity. */
declare namespace activity {

    /** Properties of a G_OPEN. */
    interface IG_OPEN {

        /** G_OPEN atype */
        atype?: (number|null);

        /** G_OPEN activity_id */
        activity_id?: (number|null);

        /** G_OPEN theme_id */
        theme_id?: (number|null);

        /** G_OPEN notice_time */
        notice_time?: (number|Long|null);

        /** G_OPEN start_time */
        start_time?: (number|Long|null);

        /** G_OPEN end_time */
        end_time?: (number|Long|null);

        /** G_OPEN state */
        state?: (number|null);
    }

    /** Represents a G_OPEN. */
    class G_OPEN implements IG_OPEN {

        /**
         * Constructs a new G_OPEN.
         * @param [properties] Properties to set
         */
        constructor(properties?: activity.IG_OPEN);

        /** G_OPEN atype. */
        public atype: number;

        /** G_OPEN activity_id. */
        public activity_id: number;

        /** G_OPEN theme_id. */
        public theme_id: number;

        /** G_OPEN notice_time. */
        public notice_time: (number|Long);

        /** G_OPEN start_time. */
        public start_time: (number|Long);

        /** G_OPEN end_time. */
        public end_time: (number|Long);

        /** G_OPEN state. */
        public state: number;

        /**
         * Creates a new G_OPEN instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_OPEN instance
         */
        public static create(properties?: activity.IG_OPEN): activity.G_OPEN;

        /**
         * Encodes the specified G_OPEN message. Does not implicitly {@link activity.G_OPEN.verify|verify} messages.
         * @param message G_OPEN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: activity.IG_OPEN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_OPEN message, length delimited. Does not implicitly {@link activity.G_OPEN.verify|verify} messages.
         * @param message G_OPEN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: activity.IG_OPEN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_OPEN message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_OPEN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): activity.G_OPEN;

        /**
         * Decodes a G_OPEN message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_OPEN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): activity.G_OPEN;

        /**
         * Verifies a G_OPEN message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_JOIN. */
    interface IU_JOIN {

        /** U_JOIN atype */
        atype?: (number|null);
    }

    /** Represents a U_JOIN. */
    class U_JOIN implements IU_JOIN {

        /**
         * Constructs a new U_JOIN.
         * @param [properties] Properties to set
         */
        constructor(properties?: activity.IU_JOIN);

        /** U_JOIN atype. */
        public atype: number;

        /**
         * Creates a new U_JOIN instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_JOIN instance
         */
        public static create(properties?: activity.IU_JOIN): activity.U_JOIN;

        /**
         * Encodes the specified U_JOIN message. Does not implicitly {@link activity.U_JOIN.verify|verify} messages.
         * @param message U_JOIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: activity.IU_JOIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_JOIN message, length delimited. Does not implicitly {@link activity.U_JOIN.verify|verify} messages.
         * @param message U_JOIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: activity.IU_JOIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_JOIN message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_JOIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): activity.U_JOIN;

        /**
         * Decodes a U_JOIN message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_JOIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): activity.U_JOIN;

        /**
         * Verifies a U_JOIN message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_JOIN. */
    interface IG_JOIN {

        /** G_JOIN atype */
        atype?: (number|null);

        /** G_JOIN succ */
        succ?: (boolean|null);
    }

    /** Represents a G_JOIN. */
    class G_JOIN implements IG_JOIN {

        /**
         * Constructs a new G_JOIN.
         * @param [properties] Properties to set
         */
        constructor(properties?: activity.IG_JOIN);

        /** G_JOIN atype. */
        public atype: number;

        /** G_JOIN succ. */
        public succ: boolean;

        /**
         * Creates a new G_JOIN instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_JOIN instance
         */
        public static create(properties?: activity.IG_JOIN): activity.G_JOIN;

        /**
         * Encodes the specified G_JOIN message. Does not implicitly {@link activity.G_JOIN.verify|verify} messages.
         * @param message G_JOIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: activity.IG_JOIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_JOIN message, length delimited. Does not implicitly {@link activity.G_JOIN.verify|verify} messages.
         * @param message G_JOIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: activity.IG_JOIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_JOIN message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_JOIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): activity.G_JOIN;

        /**
         * Decodes a G_JOIN message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_JOIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): activity.G_JOIN;

        /**
         * Verifies a G_JOIN message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_END. */
    interface IU_END {

        /** U_END atype */
        atype?: (number|null);
    }

    /** Represents a U_END. */
    class U_END implements IU_END {

        /**
         * Constructs a new U_END.
         * @param [properties] Properties to set
         */
        constructor(properties?: activity.IU_END);

        /** U_END atype. */
        public atype: number;

        /**
         * Creates a new U_END instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_END instance
         */
        public static create(properties?: activity.IU_END): activity.U_END;

        /**
         * Encodes the specified U_END message. Does not implicitly {@link activity.U_END.verify|verify} messages.
         * @param message U_END message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: activity.IU_END, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_END message, length delimited. Does not implicitly {@link activity.U_END.verify|verify} messages.
         * @param message U_END message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: activity.IU_END, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_END message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_END
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): activity.U_END;

        /**
         * Decodes a U_END message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_END
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): activity.U_END;

        /**
         * Verifies a U_END message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_CLOSE. */
    interface IU_CLOSE {

        /** U_CLOSE atype */
        atype?: (number|null);
    }

    /** Represents a U_CLOSE. */
    class U_CLOSE implements IU_CLOSE {

        /**
         * Constructs a new U_CLOSE.
         * @param [properties] Properties to set
         */
        constructor(properties?: activity.IU_CLOSE);

        /** U_CLOSE atype. */
        public atype: number;

        /**
         * Creates a new U_CLOSE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_CLOSE instance
         */
        public static create(properties?: activity.IU_CLOSE): activity.U_CLOSE;

        /**
         * Encodes the specified U_CLOSE message. Does not implicitly {@link activity.U_CLOSE.verify|verify} messages.
         * @param message U_CLOSE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: activity.IU_CLOSE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_CLOSE message, length delimited. Does not implicitly {@link activity.U_CLOSE.verify|verify} messages.
         * @param message U_CLOSE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: activity.IU_CLOSE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_CLOSE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_CLOSE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): activity.U_CLOSE;

        /**
         * Decodes a U_CLOSE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_CLOSE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): activity.U_CLOSE;

        /**
         * Verifies a U_CLOSE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace ad. */
declare namespace ad {

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO isvip */
        isvip?: (boolean|null);

        /** G_INFO box_time */
        box_time?: (number|Long|null);

        /** G_INFO speed_etime */
        speed_etime?: (number|Long|null);

        /** G_INFO effective_time */
        effective_time?: (number|Long|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: ad.IG_INFO);

        /** G_INFO isvip. */
        public isvip: boolean;

        /** G_INFO box_time. */
        public box_time: (number|Long);

        /** G_INFO speed_etime. */
        public speed_etime: (number|Long);

        /** G_INFO effective_time. */
        public effective_time: (number|Long);

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: ad.IG_INFO): ad.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link ad.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: ad.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link ad.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: ad.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): ad.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): ad.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_USE_TICKET. */
    interface IU_USE_TICKET {

        /** U_USE_TICKET use_count */
        use_count?: (number|null);
    }

    /** Represents a U_USE_TICKET. */
    class U_USE_TICKET implements IU_USE_TICKET {

        /**
         * Constructs a new U_USE_TICKET.
         * @param [properties] Properties to set
         */
        constructor(properties?: ad.IU_USE_TICKET);

        /** U_USE_TICKET use_count. */
        public use_count: number;

        /**
         * Creates a new U_USE_TICKET instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_USE_TICKET instance
         */
        public static create(properties?: ad.IU_USE_TICKET): ad.U_USE_TICKET;

        /**
         * Encodes the specified U_USE_TICKET message. Does not implicitly {@link ad.U_USE_TICKET.verify|verify} messages.
         * @param message U_USE_TICKET message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: ad.IU_USE_TICKET, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_USE_TICKET message, length delimited. Does not implicitly {@link ad.U_USE_TICKET.verify|verify} messages.
         * @param message U_USE_TICKET message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: ad.IU_USE_TICKET, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_USE_TICKET message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_USE_TICKET
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): ad.U_USE_TICKET;

        /**
         * Decodes a U_USE_TICKET message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_USE_TICKET
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): ad.U_USE_TICKET;

        /**
         * Verifies a U_USE_TICKET message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_FREE. */
    interface IU_FREE {

        /** U_FREE count */
        count?: (number|null);

        /** U_FREE box_time */
        box_time?: (number|Long|null);
    }

    /** Represents a U_FREE. */
    class U_FREE implements IU_FREE {

        /**
         * Constructs a new U_FREE.
         * @param [properties] Properties to set
         */
        constructor(properties?: ad.IU_FREE);

        /** U_FREE count. */
        public count: number;

        /** U_FREE box_time. */
        public box_time: (number|Long);

        /**
         * Creates a new U_FREE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_FREE instance
         */
        public static create(properties?: ad.IU_FREE): ad.U_FREE;

        /**
         * Encodes the specified U_FREE message. Does not implicitly {@link ad.U_FREE.verify|verify} messages.
         * @param message U_FREE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: ad.IU_FREE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_FREE message, length delimited. Does not implicitly {@link ad.U_FREE.verify|verify} messages.
         * @param message U_FREE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: ad.IU_FREE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_FREE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_FREE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): ad.U_FREE;

        /**
         * Decodes a U_FREE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_FREE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): ad.U_FREE;

        /**
         * Verifies a U_FREE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_SPEED. */
    interface IU_SPEED {

        /** U_SPEED speed_etime */
        speed_etime?: (number|Long|null);
    }

    /** Represents a U_SPEED. */
    class U_SPEED implements IU_SPEED {

        /**
         * Constructs a new U_SPEED.
         * @param [properties] Properties to set
         */
        constructor(properties?: ad.IU_SPEED);

        /** U_SPEED speed_etime. */
        public speed_etime: (number|Long);

        /**
         * Creates a new U_SPEED instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_SPEED instance
         */
        public static create(properties?: ad.IU_SPEED): ad.U_SPEED;

        /**
         * Encodes the specified U_SPEED message. Does not implicitly {@link ad.U_SPEED.verify|verify} messages.
         * @param message U_SPEED message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: ad.IU_SPEED, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_SPEED message, length delimited. Does not implicitly {@link ad.U_SPEED.verify|verify} messages.
         * @param message U_SPEED message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: ad.IU_SPEED, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_SPEED message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_SPEED
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): ad.U_SPEED;

        /**
         * Decodes a U_SPEED message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_SPEED
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): ad.U_SPEED;

        /**
         * Verifies a U_SPEED message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_DOT. */
    interface IU_DOT {

        /** U_DOT req_time */
        req_time?: (number|null);

        /** U_DOT adid */
        adid?: (number|null);

        /** U_DOT state */
        state?: (number|null);

        /** U_DOT channel */
        channel?: (string|null);

        /** U_DOT dollar */
        dollar?: (number|null);

        /** U_DOT error_code */
        error_code?: (number|null);
    }

    /** Represents a U_DOT. */
    class U_DOT implements IU_DOT {

        /**
         * Constructs a new U_DOT.
         * @param [properties] Properties to set
         */
        constructor(properties?: ad.IU_DOT);

        /** U_DOT req_time. */
        public req_time: number;

        /** U_DOT adid. */
        public adid: number;

        /** U_DOT state. */
        public state: number;

        /** U_DOT channel. */
        public channel: string;

        /** U_DOT dollar. */
        public dollar: number;

        /** U_DOT error_code. */
        public error_code: number;

        /**
         * Creates a new U_DOT instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_DOT instance
         */
        public static create(properties?: ad.IU_DOT): ad.U_DOT;

        /**
         * Encodes the specified U_DOT message. Does not implicitly {@link ad.U_DOT.verify|verify} messages.
         * @param message U_DOT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: ad.IU_DOT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_DOT message, length delimited. Does not implicitly {@link ad.U_DOT.verify|verify} messages.
         * @param message U_DOT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: ad.IU_DOT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_DOT message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_DOT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): ad.U_DOT;

        /**
         * Decodes a U_DOT message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_DOT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): ad.U_DOT;

        /**
         * Verifies a U_DOT message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_DISCOUNT_TIME. */
    interface IU_DISCOUNT_TIME {

        /** U_DISCOUNT_TIME effective_time */
        effective_time?: (number|Long|null);
    }

    /** Represents a U_DISCOUNT_TIME. */
    class U_DISCOUNT_TIME implements IU_DISCOUNT_TIME {

        /**
         * Constructs a new U_DISCOUNT_TIME.
         * @param [properties] Properties to set
         */
        constructor(properties?: ad.IU_DISCOUNT_TIME);

        /** U_DISCOUNT_TIME effective_time. */
        public effective_time: (number|Long);

        /**
         * Creates a new U_DISCOUNT_TIME instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_DISCOUNT_TIME instance
         */
        public static create(properties?: ad.IU_DISCOUNT_TIME): ad.U_DISCOUNT_TIME;

        /**
         * Encodes the specified U_DISCOUNT_TIME message. Does not implicitly {@link ad.U_DISCOUNT_TIME.verify|verify} messages.
         * @param message U_DISCOUNT_TIME message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: ad.IU_DISCOUNT_TIME, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_DISCOUNT_TIME message, length delimited. Does not implicitly {@link ad.U_DISCOUNT_TIME.verify|verify} messages.
         * @param message U_DISCOUNT_TIME message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: ad.IU_DISCOUNT_TIME, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_DISCOUNT_TIME message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_DISCOUNT_TIME
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): ad.U_DISCOUNT_TIME;

        /**
         * Decodes a U_DISCOUNT_TIME message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_DISCOUNT_TIME
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): ad.U_DISCOUNT_TIME;

        /**
         * Verifies a U_DISCOUNT_TIME message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace base. */
declare namespace base {

    /** Properties of a U_LOGIN. */
    interface IU_LOGIN {

        /** U_LOGIN login_type */
        login_type?: (number|null);

        /** U_LOGIN account */
        account?: (string|null);

        /** U_LOGIN lang */
        lang?: (number|null);

        /** U_LOGIN platform */
        platform?: (number|null);

        /** U_LOGIN country */
        country?: (string|null);

        /** U_LOGIN device */
        device?: (string|null);

        /** U_LOGIN version */
        version?: (string|null);

        /** U_LOGIN exl_version */
        exl_version?: (number|null);

        /** U_LOGIN playerid */
        playerid?: (number|Long|null);
    }

    /** Represents a U_LOGIN. */
    class U_LOGIN implements IU_LOGIN {

        /**
         * Constructs a new U_LOGIN.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IU_LOGIN);

        /** U_LOGIN login_type. */
        public login_type: number;

        /** U_LOGIN account. */
        public account: string;

        /** U_LOGIN lang. */
        public lang: number;

        /** U_LOGIN platform. */
        public platform: number;

        /** U_LOGIN country. */
        public country: string;

        /** U_LOGIN device. */
        public device: string;

        /** U_LOGIN version. */
        public version: string;

        /** U_LOGIN exl_version. */
        public exl_version: number;

        /** U_LOGIN playerid. */
        public playerid: (number|Long);

        /**
         * Creates a new U_LOGIN instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_LOGIN instance
         */
        public static create(properties?: base.IU_LOGIN): base.U_LOGIN;

        /**
         * Encodes the specified U_LOGIN message. Does not implicitly {@link base.U_LOGIN.verify|verify} messages.
         * @param message U_LOGIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IU_LOGIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_LOGIN message, length delimited. Does not implicitly {@link base.U_LOGIN.verify|verify} messages.
         * @param message U_LOGIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IU_LOGIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_LOGIN message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_LOGIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.U_LOGIN;

        /**
         * Decodes a U_LOGIN message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_LOGIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.U_LOGIN;

        /**
         * Verifies a U_LOGIN message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_LOGIN. */
    interface IG_LOGIN {

        /** G_LOGIN playerid */
        playerid?: (number|Long|null);

        /** G_LOGIN token */
        token?: (string|null);

        /** G_LOGIN time */
        time?: (number|Long|null);

        /** G_LOGIN create_time */
        create_time?: (number|null);

        /** G_LOGIN ischange */
        ischange?: (boolean|null);

        /** G_LOGIN snapshotid */
        snapshotid?: (number|Long|null);

        /** G_LOGIN gm_recharge */
        gm_recharge?: (boolean|null);

        /** G_LOGIN time_zone */
        time_zone?: (string|null);

        /** G_LOGIN exl_version */
        exl_version?: (number|null);
    }

    /** Represents a G_LOGIN. */
    class G_LOGIN implements IG_LOGIN {

        /**
         * Constructs a new G_LOGIN.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IG_LOGIN);

        /** G_LOGIN playerid. */
        public playerid: (number|Long);

        /** G_LOGIN token. */
        public token: string;

        /** G_LOGIN time. */
        public time: (number|Long);

        /** G_LOGIN create_time. */
        public create_time: number;

        /** G_LOGIN ischange. */
        public ischange: boolean;

        /** G_LOGIN snapshotid. */
        public snapshotid: (number|Long);

        /** G_LOGIN gm_recharge. */
        public gm_recharge: boolean;

        /** G_LOGIN time_zone. */
        public time_zone: string;

        /** G_LOGIN exl_version. */
        public exl_version: number;

        /**
         * Creates a new G_LOGIN instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_LOGIN instance
         */
        public static create(properties?: base.IG_LOGIN): base.G_LOGIN;

        /**
         * Encodes the specified G_LOGIN message. Does not implicitly {@link base.G_LOGIN.verify|verify} messages.
         * @param message G_LOGIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IG_LOGIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_LOGIN message, length delimited. Does not implicitly {@link base.G_LOGIN.verify|verify} messages.
         * @param message G_LOGIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IG_LOGIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_LOGIN message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_LOGIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.G_LOGIN;

        /**
         * Decodes a G_LOGIN message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_LOGIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.G_LOGIN;

        /**
         * Verifies a G_LOGIN message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_RELOGIN. */
    interface IU_RELOGIN {

        /** U_RELOGIN playerid */
        playerid?: (number|Long|null);

        /** U_RELOGIN token */
        token?: (string|null);
    }

    /** Represents a U_RELOGIN. */
    class U_RELOGIN implements IU_RELOGIN {

        /**
         * Constructs a new U_RELOGIN.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IU_RELOGIN);

        /** U_RELOGIN playerid. */
        public playerid: (number|Long);

        /** U_RELOGIN token. */
        public token: string;

        /**
         * Creates a new U_RELOGIN instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_RELOGIN instance
         */
        public static create(properties?: base.IU_RELOGIN): base.U_RELOGIN;

        /**
         * Encodes the specified U_RELOGIN message. Does not implicitly {@link base.U_RELOGIN.verify|verify} messages.
         * @param message U_RELOGIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IU_RELOGIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_RELOGIN message, length delimited. Does not implicitly {@link base.U_RELOGIN.verify|verify} messages.
         * @param message U_RELOGIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IU_RELOGIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_RELOGIN message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_RELOGIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.U_RELOGIN;

        /**
         * Decodes a U_RELOGIN message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_RELOGIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.U_RELOGIN;

        /**
         * Verifies a U_RELOGIN message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_RELOGIN. */
    interface IG_RELOGIN {

        /** G_RELOGIN time */
        time?: (number|Long|null);

        /** G_RELOGIN snapshotid */
        snapshotid?: (number|Long|null);
    }

    /** Represents a G_RELOGIN. */
    class G_RELOGIN implements IG_RELOGIN {

        /**
         * Constructs a new G_RELOGIN.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IG_RELOGIN);

        /** G_RELOGIN time. */
        public time: (number|Long);

        /** G_RELOGIN snapshotid. */
        public snapshotid: (number|Long);

        /**
         * Creates a new G_RELOGIN instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_RELOGIN instance
         */
        public static create(properties?: base.IG_RELOGIN): base.G_RELOGIN;

        /**
         * Encodes the specified G_RELOGIN message. Does not implicitly {@link base.G_RELOGIN.verify|verify} messages.
         * @param message G_RELOGIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IG_RELOGIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_RELOGIN message, length delimited. Does not implicitly {@link base.G_RELOGIN.verify|verify} messages.
         * @param message G_RELOGIN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IG_RELOGIN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_RELOGIN message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_RELOGIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.G_RELOGIN;

        /**
         * Decodes a G_RELOGIN message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_RELOGIN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.G_RELOGIN;

        /**
         * Verifies a G_RELOGIN message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_SYNC. */
    interface IU_SYNC {

        /** U_SYNC snapshotid */
        snapshotid?: (number|Long|null);

        /** U_SYNC buffs */
        buffs?: (Uint8Array[]|null);
    }

    /** Represents a U_SYNC. */
    class U_SYNC implements IU_SYNC {

        /**
         * Constructs a new U_SYNC.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IU_SYNC);

        /** U_SYNC snapshotid. */
        public snapshotid: (number|Long);

        /** U_SYNC buffs. */
        public buffs: Uint8Array[];

        /**
         * Creates a new U_SYNC instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_SYNC instance
         */
        public static create(properties?: base.IU_SYNC): base.U_SYNC;

        /**
         * Encodes the specified U_SYNC message. Does not implicitly {@link base.U_SYNC.verify|verify} messages.
         * @param message U_SYNC message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IU_SYNC, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_SYNC message, length delimited. Does not implicitly {@link base.U_SYNC.verify|verify} messages.
         * @param message U_SYNC message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IU_SYNC, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_SYNC message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_SYNC
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.U_SYNC;

        /**
         * Decodes a U_SYNC message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_SYNC
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.U_SYNC;

        /**
         * Verifies a U_SYNC message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_SYNC. */
    interface IG_SYNC {

        /** G_SYNC snapshotid */
        snapshotid?: (number|Long|null);
    }

    /** Represents a G_SYNC. */
    class G_SYNC implements IG_SYNC {

        /**
         * Constructs a new G_SYNC.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IG_SYNC);

        /** G_SYNC snapshotid. */
        public snapshotid: (number|Long);

        /**
         * Creates a new G_SYNC instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_SYNC instance
         */
        public static create(properties?: base.IG_SYNC): base.G_SYNC;

        /**
         * Encodes the specified G_SYNC message. Does not implicitly {@link base.G_SYNC.verify|verify} messages.
         * @param message G_SYNC message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IG_SYNC, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_SYNC message, length delimited. Does not implicitly {@link base.G_SYNC.verify|verify} messages.
         * @param message G_SYNC message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IG_SYNC, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_SYNC message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_SYNC
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.G_SYNC;

        /**
         * Decodes a G_SYNC message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_SYNC
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.G_SYNC;

        /**
         * Verifies a G_SYNC message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_LANG. */
    interface IU_LANG {

        /** U_LANG lang */
        lang?: (number|null);
    }

    /** Represents a U_LANG. */
    class U_LANG implements IU_LANG {

        /**
         * Constructs a new U_LANG.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IU_LANG);

        /** U_LANG lang. */
        public lang: number;

        /**
         * Creates a new U_LANG instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_LANG instance
         */
        public static create(properties?: base.IU_LANG): base.U_LANG;

        /**
         * Encodes the specified U_LANG message. Does not implicitly {@link base.U_LANG.verify|verify} messages.
         * @param message U_LANG message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IU_LANG, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_LANG message, length delimited. Does not implicitly {@link base.U_LANG.verify|verify} messages.
         * @param message U_LANG message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IU_LANG, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_LANG message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_LANG
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.U_LANG;

        /**
         * Decodes a U_LANG message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_LANG
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.U_LANG;

        /**
         * Verifies a U_LANG message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_ZERO. */
    interface IU_ZERO {
    }

    /** Represents a U_ZERO. */
    class U_ZERO implements IU_ZERO {

        /**
         * Constructs a new U_ZERO.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IU_ZERO);

        /**
         * Creates a new U_ZERO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_ZERO instance
         */
        public static create(properties?: base.IU_ZERO): base.U_ZERO;

        /**
         * Encodes the specified U_ZERO message. Does not implicitly {@link base.U_ZERO.verify|verify} messages.
         * @param message U_ZERO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IU_ZERO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_ZERO message, length delimited. Does not implicitly {@link base.U_ZERO.verify|verify} messages.
         * @param message U_ZERO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IU_ZERO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_ZERO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_ZERO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.U_ZERO;

        /**
         * Decodes a U_ZERO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_ZERO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.U_ZERO;

        /**
         * Verifies a U_ZERO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_FINISH. */
    interface IG_FINISH {
    }

    /** Represents a G_FINISH. */
    class G_FINISH implements IG_FINISH {

        /**
         * Constructs a new G_FINISH.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IG_FINISH);

        /**
         * Creates a new G_FINISH instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_FINISH instance
         */
        public static create(properties?: base.IG_FINISH): base.G_FINISH;

        /**
         * Encodes the specified G_FINISH message. Does not implicitly {@link base.G_FINISH.verify|verify} messages.
         * @param message G_FINISH message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IG_FINISH, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_FINISH message, length delimited. Does not implicitly {@link base.G_FINISH.verify|verify} messages.
         * @param message G_FINISH message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IG_FINISH, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_FINISH message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_FINISH
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.G_FINISH;

        /**
         * Decodes a G_FINISH message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_FINISH
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.G_FINISH;

        /**
         * Verifies a G_FINISH message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_HEART. */
    interface IU_HEART {
    }

    /** Represents a U_HEART. */
    class U_HEART implements IU_HEART {

        /**
         * Constructs a new U_HEART.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IU_HEART);

        /**
         * Creates a new U_HEART instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_HEART instance
         */
        public static create(properties?: base.IU_HEART): base.U_HEART;

        /**
         * Encodes the specified U_HEART message. Does not implicitly {@link base.U_HEART.verify|verify} messages.
         * @param message U_HEART message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IU_HEART, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_HEART message, length delimited. Does not implicitly {@link base.U_HEART.verify|verify} messages.
         * @param message U_HEART message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IU_HEART, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_HEART message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_HEART
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.U_HEART;

        /**
         * Decodes a U_HEART message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_HEART
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.U_HEART;

        /**
         * Verifies a U_HEART message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_HEART. */
    interface IG_HEART {

        /** G_HEART time */
        time?: (number|Long|null);
    }

    /** Represents a G_HEART. */
    class G_HEART implements IG_HEART {

        /**
         * Constructs a new G_HEART.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IG_HEART);

        /** G_HEART time. */
        public time: (number|Long);

        /**
         * Creates a new G_HEART instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_HEART instance
         */
        public static create(properties?: base.IG_HEART): base.G_HEART;

        /**
         * Encodes the specified G_HEART message. Does not implicitly {@link base.G_HEART.verify|verify} messages.
         * @param message G_HEART message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IG_HEART, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_HEART message, length delimited. Does not implicitly {@link base.G_HEART.verify|verify} messages.
         * @param message G_HEART message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IG_HEART, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_HEART message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_HEART
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.G_HEART;

        /**
         * Decodes a G_HEART message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_HEART
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.G_HEART;

        /**
         * Verifies a G_HEART message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_GMLEVEL. */
    interface IG_GMLEVEL {

        /** G_GMLEVEL gmlevel */
        gmlevel?: (number|null);
    }

    /** Represents a G_GMLEVEL. */
    class G_GMLEVEL implements IG_GMLEVEL {

        /**
         * Constructs a new G_GMLEVEL.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IG_GMLEVEL);

        /** G_GMLEVEL gmlevel. */
        public gmlevel: number;

        /**
         * Creates a new G_GMLEVEL instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_GMLEVEL instance
         */
        public static create(properties?: base.IG_GMLEVEL): base.G_GMLEVEL;

        /**
         * Encodes the specified G_GMLEVEL message. Does not implicitly {@link base.G_GMLEVEL.verify|verify} messages.
         * @param message G_GMLEVEL message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IG_GMLEVEL, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_GMLEVEL message, length delimited. Does not implicitly {@link base.G_GMLEVEL.verify|verify} messages.
         * @param message G_GMLEVEL message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IG_GMLEVEL, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_GMLEVEL message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_GMLEVEL
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.G_GMLEVEL;

        /**
         * Decodes a G_GMLEVEL message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_GMLEVEL
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.G_GMLEVEL;

        /**
         * Verifies a G_GMLEVEL message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_GM. */
    interface IU_GM {

        /** U_GM cmd */
        cmd?: (string|null);

        /** U_GM args */
        args?: (string[]|null);
    }

    /** Represents a U_GM. */
    class U_GM implements IU_GM {

        /**
         * Constructs a new U_GM.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IU_GM);

        /** U_GM cmd. */
        public cmd: string;

        /** U_GM args. */
        public args: string[];

        /**
         * Creates a new U_GM instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_GM instance
         */
        public static create(properties?: base.IU_GM): base.U_GM;

        /**
         * Encodes the specified U_GM message. Does not implicitly {@link base.U_GM.verify|verify} messages.
         * @param message U_GM message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IU_GM, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_GM message, length delimited. Does not implicitly {@link base.U_GM.verify|verify} messages.
         * @param message U_GM message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IU_GM, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_GM message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_GM
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.U_GM;

        /**
         * Decodes a U_GM message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_GM
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.U_GM;

        /**
         * Verifies a U_GM message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_ERROR. */
    interface IG_ERROR {

        /** G_ERROR op */
        op?: (number|null);

        /** G_ERROR code */
        code?: (number|null);
    }

    /** Represents a G_ERROR. */
    class G_ERROR implements IG_ERROR {

        /**
         * Constructs a new G_ERROR.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IG_ERROR);

        /** G_ERROR op. */
        public op: number;

        /** G_ERROR code. */
        public code: number;

        /**
         * Creates a new G_ERROR instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_ERROR instance
         */
        public static create(properties?: base.IG_ERROR): base.G_ERROR;

        /**
         * Encodes the specified G_ERROR message. Does not implicitly {@link base.G_ERROR.verify|verify} messages.
         * @param message G_ERROR message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IG_ERROR, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_ERROR message, length delimited. Does not implicitly {@link base.G_ERROR.verify|verify} messages.
         * @param message G_ERROR message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IG_ERROR, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_ERROR message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_ERROR
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.G_ERROR;

        /**
         * Decodes a G_ERROR message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_ERROR
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.G_ERROR;

        /**
         * Verifies a G_ERROR message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_TIP. */
    interface IG_TIP {

        /** G_TIP tip */
        tip?: (string|null);
    }

    /** Represents a G_TIP. */
    class G_TIP implements IG_TIP {

        /**
         * Constructs a new G_TIP.
         * @param [properties] Properties to set
         */
        constructor(properties?: base.IG_TIP);

        /** G_TIP tip. */
        public tip: string;

        /**
         * Creates a new G_TIP instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_TIP instance
         */
        public static create(properties?: base.IG_TIP): base.G_TIP;

        /**
         * Encodes the specified G_TIP message. Does not implicitly {@link base.G_TIP.verify|verify} messages.
         * @param message G_TIP message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: base.IG_TIP, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_TIP message, length delimited. Does not implicitly {@link base.G_TIP.verify|verify} messages.
         * @param message G_TIP message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: base.IG_TIP, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_TIP message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_TIP
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): base.G_TIP;

        /**
         * Decodes a G_TIP message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_TIP
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): base.G_TIP;

        /**
         * Verifies a G_TIP message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace buffcard. */
declare namespace buffcard {

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO cards */
        cards?: (number[]|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: buffcard.IG_INFO);

        /** G_INFO cards. */
        public cards: number[];

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: buffcard.IG_INFO): buffcard.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link buffcard.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: buffcard.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link buffcard.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: buffcard.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): buffcard.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): buffcard.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace card. */
declare namespace card {

    /** Properties of a CARD. */
    interface ICARD {

        /** CARD level */
        level?: (number|null);

        /** CARD star */
        star?: (number|null);

        /** CARD count */
        count?: (number|null);
    }

    /** Represents a CARD. */
    class CARD implements ICARD {

        /**
         * Constructs a new CARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: card.ICARD);

        /** CARD level. */
        public level: number;

        /** CARD star. */
        public star: number;

        /** CARD count. */
        public count: number;

        /**
         * Creates a new CARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns CARD instance
         */
        public static create(properties?: card.ICARD): card.CARD;

        /**
         * Encodes the specified CARD message. Does not implicitly {@link card.CARD.verify|verify} messages.
         * @param message CARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: card.ICARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified CARD message, length delimited. Does not implicitly {@link card.CARD.verify|verify} messages.
         * @param message CARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: card.ICARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a CARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns CARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): card.CARD;

        /**
         * Decodes a CARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns CARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): card.CARD;

        /**
         * Verifies a CARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a PIECE. */
    interface IPIECE {

        /** PIECE count */
        count?: (number|null);
    }

    /** Represents a PIECE. */
    class PIECE implements IPIECE {

        /**
         * Constructs a new PIECE.
         * @param [properties] Properties to set
         */
        constructor(properties?: card.IPIECE);

        /** PIECE count. */
        public count: number;

        /**
         * Creates a new PIECE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns PIECE instance
         */
        public static create(properties?: card.IPIECE): card.PIECE;

        /**
         * Encodes the specified PIECE message. Does not implicitly {@link card.PIECE.verify|verify} messages.
         * @param message PIECE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: card.IPIECE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified PIECE message, length delimited. Does not implicitly {@link card.PIECE.verify|verify} messages.
         * @param message PIECE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: card.IPIECE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a PIECE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns PIECE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): card.PIECE;

        /**
         * Decodes a PIECE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns PIECE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): card.PIECE;

        /**
         * Verifies a PIECE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO cards */
        cards?: ({ [k: string]: card.ICARD }|null);

        /** G_INFO pieces */
        pieces?: ({ [k: string]: card.IPIECE }|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: card.IG_INFO);

        /** G_INFO cards. */
        public cards: { [k: string]: card.ICARD };

        /** G_INFO pieces. */
        public pieces: { [k: string]: card.IPIECE };

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: card.IG_INFO): card.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link card.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: card.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link card.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: card.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): card.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): card.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_UP_LEVEL. */
    interface IU_UP_LEVEL {

        /** U_UP_LEVEL card_id */
        card_id?: (number|null);

        /** U_UP_LEVEL level */
        level?: (number|null);
    }

    /** Represents a U_UP_LEVEL. */
    class U_UP_LEVEL implements IU_UP_LEVEL {

        /**
         * Constructs a new U_UP_LEVEL.
         * @param [properties] Properties to set
         */
        constructor(properties?: card.IU_UP_LEVEL);

        /** U_UP_LEVEL card_id. */
        public card_id: number;

        /** U_UP_LEVEL level. */
        public level: number;

        /**
         * Creates a new U_UP_LEVEL instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_UP_LEVEL instance
         */
        public static create(properties?: card.IU_UP_LEVEL): card.U_UP_LEVEL;

        /**
         * Encodes the specified U_UP_LEVEL message. Does not implicitly {@link card.U_UP_LEVEL.verify|verify} messages.
         * @param message U_UP_LEVEL message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: card.IU_UP_LEVEL, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_UP_LEVEL message, length delimited. Does not implicitly {@link card.U_UP_LEVEL.verify|verify} messages.
         * @param message U_UP_LEVEL message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: card.IU_UP_LEVEL, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_UP_LEVEL message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_UP_LEVEL
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): card.U_UP_LEVEL;

        /**
         * Decodes a U_UP_LEVEL message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_UP_LEVEL
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): card.U_UP_LEVEL;

        /**
         * Verifies a U_UP_LEVEL message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_UP_STAR. */
    interface IU_UP_STAR {

        /** U_UP_STAR card_id */
        card_id?: (number|null);

        /** U_UP_STAR cards */
        cards?: ({ [k: string]: number }|null);
    }

    /** Represents a U_UP_STAR. */
    class U_UP_STAR implements IU_UP_STAR {

        /**
         * Constructs a new U_UP_STAR.
         * @param [properties] Properties to set
         */
        constructor(properties?: card.IU_UP_STAR);

        /** U_UP_STAR card_id. */
        public card_id: number;

        /** U_UP_STAR cards. */
        public cards: { [k: string]: number };

        /**
         * Creates a new U_UP_STAR instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_UP_STAR instance
         */
        public static create(properties?: card.IU_UP_STAR): card.U_UP_STAR;

        /**
         * Encodes the specified U_UP_STAR message. Does not implicitly {@link card.U_UP_STAR.verify|verify} messages.
         * @param message U_UP_STAR message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: card.IU_UP_STAR, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_UP_STAR message, length delimited. Does not implicitly {@link card.U_UP_STAR.verify|verify} messages.
         * @param message U_UP_STAR message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: card.IU_UP_STAR, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_UP_STAR message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_UP_STAR
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): card.U_UP_STAR;

        /**
         * Decodes a U_UP_STAR message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_UP_STAR
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): card.U_UP_STAR;

        /**
         * Verifies a U_UP_STAR message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_COMBINE. */
    interface IU_COMBINE {

        /** U_COMBINE piece_id */
        piece_id?: (number|null);

        /** U_COMBINE num */
        num?: (number|null);
    }

    /** Represents a U_COMBINE. */
    class U_COMBINE implements IU_COMBINE {

        /**
         * Constructs a new U_COMBINE.
         * @param [properties] Properties to set
         */
        constructor(properties?: card.IU_COMBINE);

        /** U_COMBINE piece_id. */
        public piece_id: number;

        /** U_COMBINE num. */
        public num: number;

        /**
         * Creates a new U_COMBINE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_COMBINE instance
         */
        public static create(properties?: card.IU_COMBINE): card.U_COMBINE;

        /**
         * Encodes the specified U_COMBINE message. Does not implicitly {@link card.U_COMBINE.verify|verify} messages.
         * @param message U_COMBINE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: card.IU_COMBINE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_COMBINE message, length delimited. Does not implicitly {@link card.U_COMBINE.verify|verify} messages.
         * @param message U_COMBINE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: card.IU_COMBINE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_COMBINE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_COMBINE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): card.U_COMBINE;

        /**
         * Decodes a U_COMBINE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_COMBINE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): card.U_COMBINE;

        /**
         * Verifies a U_COMBINE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_EXCHANGE. */
    interface IU_EXCHANGE {

        /** U_EXCHANGE exchange_id */
        exchange_id?: (number|null);

        /** U_EXCHANGE num */
        num?: (number|null);

        /** U_EXCHANGE cards */
        cards?: ({ [k: string]: number }|null);
    }

    /** Represents a U_EXCHANGE. */
    class U_EXCHANGE implements IU_EXCHANGE {

        /**
         * Constructs a new U_EXCHANGE.
         * @param [properties] Properties to set
         */
        constructor(properties?: card.IU_EXCHANGE);

        /** U_EXCHANGE exchange_id. */
        public exchange_id: number;

        /** U_EXCHANGE num. */
        public num: number;

        /** U_EXCHANGE cards. */
        public cards: { [k: string]: number };

        /**
         * Creates a new U_EXCHANGE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_EXCHANGE instance
         */
        public static create(properties?: card.IU_EXCHANGE): card.U_EXCHANGE;

        /**
         * Encodes the specified U_EXCHANGE message. Does not implicitly {@link card.U_EXCHANGE.verify|verify} messages.
         * @param message U_EXCHANGE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: card.IU_EXCHANGE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_EXCHANGE message, length delimited. Does not implicitly {@link card.U_EXCHANGE.verify|verify} messages.
         * @param message U_EXCHANGE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: card.IU_EXCHANGE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_EXCHANGE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_EXCHANGE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): card.U_EXCHANGE;

        /**
         * Decodes a U_EXCHANGE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_EXCHANGE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): card.U_EXCHANGE;

        /**
         * Verifies a U_EXCHANGE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace chapter. */
declare namespace chapter {

    /** Properties of a ENTRY. */
    interface IENTRY {

        /** ENTRY entry_level */
        entry_level?: (number|null);
    }

    /** Represents a ENTRY. */
    class ENTRY implements IENTRY {

        /**
         * Constructs a new ENTRY.
         * @param [properties] Properties to set
         */
        constructor(properties?: chapter.IENTRY);

        /** ENTRY entry_level. */
        public entry_level: number;

        /**
         * Creates a new ENTRY instance using the specified properties.
         * @param [properties] Properties to set
         * @returns ENTRY instance
         */
        public static create(properties?: chapter.IENTRY): chapter.ENTRY;

        /**
         * Encodes the specified ENTRY message. Does not implicitly {@link chapter.ENTRY.verify|verify} messages.
         * @param message ENTRY message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: chapter.IENTRY, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified ENTRY message, length delimited. Does not implicitly {@link chapter.ENTRY.verify|verify} messages.
         * @param message ENTRY message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: chapter.IENTRY, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a ENTRY message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns ENTRY
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): chapter.ENTRY;

        /**
         * Decodes a ENTRY message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns ENTRY
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): chapter.ENTRY;

        /**
         * Verifies a ENTRY message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a CARD. */
    interface ICARD {

        /** CARD card_id */
        card_id?: (number|null);
    }

    /** Represents a CARD. */
    class CARD implements ICARD {

        /**
         * Constructs a new CARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: chapter.ICARD);

        /** CARD card_id. */
        public card_id: number;

        /**
         * Creates a new CARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns CARD instance
         */
        public static create(properties?: chapter.ICARD): chapter.CARD;

        /**
         * Encodes the specified CARD message. Does not implicitly {@link chapter.CARD.verify|verify} messages.
         * @param message CARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: chapter.ICARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified CARD message, length delimited. Does not implicitly {@link chapter.CARD.verify|verify} messages.
         * @param message CARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: chapter.ICARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a CARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns CARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): chapter.CARD;

        /**
         * Decodes a CARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns CARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): chapter.CARD;

        /**
         * Verifies a CARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a DEPARTMENT. */
    interface IDEPARTMENT {

        /** DEPARTMENT department_level */
        department_level?: (number|null);

        /** DEPARTMENT entries */
        entries?: ({ [k: string]: chapter.IENTRY }|null);

        /** DEPARTMENT cards */
        cards?: ({ [k: string]: chapter.ICARD }|null);
    }

    /** Represents a DEPARTMENT. */
    class DEPARTMENT implements IDEPARTMENT {

        /**
         * Constructs a new DEPARTMENT.
         * @param [properties] Properties to set
         */
        constructor(properties?: chapter.IDEPARTMENT);

        /** DEPARTMENT department_level. */
        public department_level: number;

        /** DEPARTMENT entries. */
        public entries: { [k: string]: chapter.IENTRY };

        /** DEPARTMENT cards. */
        public cards: { [k: string]: chapter.ICARD };

        /**
         * Creates a new DEPARTMENT instance using the specified properties.
         * @param [properties] Properties to set
         * @returns DEPARTMENT instance
         */
        public static create(properties?: chapter.IDEPARTMENT): chapter.DEPARTMENT;

        /**
         * Encodes the specified DEPARTMENT message. Does not implicitly {@link chapter.DEPARTMENT.verify|verify} messages.
         * @param message DEPARTMENT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: chapter.IDEPARTMENT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified DEPARTMENT message, length delimited. Does not implicitly {@link chapter.DEPARTMENT.verify|verify} messages.
         * @param message DEPARTMENT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: chapter.IDEPARTMENT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a DEPARTMENT message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns DEPARTMENT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): chapter.DEPARTMENT;

        /**
         * Decodes a DEPARTMENT message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns DEPARTMENT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): chapter.DEPARTMENT;

        /**
         * Verifies a DEPARTMENT message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO chapter_level */
        chapter_level?: (number|null);

        /** G_INFO departments */
        departments?: ({ [k: string]: chapter.IDEPARTMENT }|null);

        /** G_INFO ispass */
        ispass?: (boolean|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: chapter.IG_INFO);

        /** G_INFO chapter_level. */
        public chapter_level: number;

        /** G_INFO departments. */
        public departments: { [k: string]: chapter.IDEPARTMENT };

        /** G_INFO ispass. */
        public ispass: boolean;

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: chapter.IG_INFO): chapter.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link chapter.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: chapter.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link chapter.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: chapter.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): chapter.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): chapter.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_UP_DEPARTMENT. */
    interface IU_UP_DEPARTMENT {

        /** U_UP_DEPARTMENT department_id */
        department_id?: (number|null);
    }

    /** Represents a U_UP_DEPARTMENT. */
    class U_UP_DEPARTMENT implements IU_UP_DEPARTMENT {

        /**
         * Constructs a new U_UP_DEPARTMENT.
         * @param [properties] Properties to set
         */
        constructor(properties?: chapter.IU_UP_DEPARTMENT);

        /** U_UP_DEPARTMENT department_id. */
        public department_id: number;

        /**
         * Creates a new U_UP_DEPARTMENT instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_UP_DEPARTMENT instance
         */
        public static create(properties?: chapter.IU_UP_DEPARTMENT): chapter.U_UP_DEPARTMENT;

        /**
         * Encodes the specified U_UP_DEPARTMENT message. Does not implicitly {@link chapter.U_UP_DEPARTMENT.verify|verify} messages.
         * @param message U_UP_DEPARTMENT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: chapter.IU_UP_DEPARTMENT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_UP_DEPARTMENT message, length delimited. Does not implicitly {@link chapter.U_UP_DEPARTMENT.verify|verify} messages.
         * @param message U_UP_DEPARTMENT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: chapter.IU_UP_DEPARTMENT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_UP_DEPARTMENT message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_UP_DEPARTMENT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): chapter.U_UP_DEPARTMENT;

        /**
         * Decodes a U_UP_DEPARTMENT message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_UP_DEPARTMENT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): chapter.U_UP_DEPARTMENT;

        /**
         * Verifies a U_UP_DEPARTMENT message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_UP_ENTRY. */
    interface IU_UP_ENTRY {

        /** U_UP_ENTRY department_id */
        department_id?: (number|null);

        /** U_UP_ENTRY entry_id */
        entry_id?: (number|null);

        /** U_UP_ENTRY entry_level */
        entry_level?: (number|null);
    }

    /** Represents a U_UP_ENTRY. */
    class U_UP_ENTRY implements IU_UP_ENTRY {

        /**
         * Constructs a new U_UP_ENTRY.
         * @param [properties] Properties to set
         */
        constructor(properties?: chapter.IU_UP_ENTRY);

        /** U_UP_ENTRY department_id. */
        public department_id: number;

        /** U_UP_ENTRY entry_id. */
        public entry_id: number;

        /** U_UP_ENTRY entry_level. */
        public entry_level: number;

        /**
         * Creates a new U_UP_ENTRY instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_UP_ENTRY instance
         */
        public static create(properties?: chapter.IU_UP_ENTRY): chapter.U_UP_ENTRY;

        /**
         * Encodes the specified U_UP_ENTRY message. Does not implicitly {@link chapter.U_UP_ENTRY.verify|verify} messages.
         * @param message U_UP_ENTRY message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: chapter.IU_UP_ENTRY, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_UP_ENTRY message, length delimited. Does not implicitly {@link chapter.U_UP_ENTRY.verify|verify} messages.
         * @param message U_UP_ENTRY message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: chapter.IU_UP_ENTRY, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_UP_ENTRY message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_UP_ENTRY
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): chapter.U_UP_ENTRY;

        /**
         * Decodes a U_UP_ENTRY message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_UP_ENTRY
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): chapter.U_UP_ENTRY;

        /**
         * Verifies a U_UP_ENTRY message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_LAY_CARD. */
    interface IU_LAY_CARD {

        /** U_LAY_CARD department_id */
        department_id?: (number|null);

        /** U_LAY_CARD index */
        index?: (number|null);

        /** U_LAY_CARD card_id */
        card_id?: (number|null);
    }

    /** Represents a U_LAY_CARD. */
    class U_LAY_CARD implements IU_LAY_CARD {

        /**
         * Constructs a new U_LAY_CARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: chapter.IU_LAY_CARD);

        /** U_LAY_CARD department_id. */
        public department_id: number;

        /** U_LAY_CARD index. */
        public index: number;

        /** U_LAY_CARD card_id. */
        public card_id: number;

        /**
         * Creates a new U_LAY_CARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_LAY_CARD instance
         */
        public static create(properties?: chapter.IU_LAY_CARD): chapter.U_LAY_CARD;

        /**
         * Encodes the specified U_LAY_CARD message. Does not implicitly {@link chapter.U_LAY_CARD.verify|verify} messages.
         * @param message U_LAY_CARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: chapter.IU_LAY_CARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_LAY_CARD message, length delimited. Does not implicitly {@link chapter.U_LAY_CARD.verify|verify} messages.
         * @param message U_LAY_CARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: chapter.IU_LAY_CARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_LAY_CARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_LAY_CARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): chapter.U_LAY_CARD;

        /**
         * Decodes a U_LAY_CARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_LAY_CARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): chapter.U_LAY_CARD;

        /**
         * Verifies a U_LAY_CARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_UP_CHAPTER. */
    interface IU_UP_CHAPTER {

        /** U_UP_CHAPTER chapter_level */
        chapter_level?: (number|null);
    }

    /** Represents a U_UP_CHAPTER. */
    class U_UP_CHAPTER implements IU_UP_CHAPTER {

        /**
         * Constructs a new U_UP_CHAPTER.
         * @param [properties] Properties to set
         */
        constructor(properties?: chapter.IU_UP_CHAPTER);

        /** U_UP_CHAPTER chapter_level. */
        public chapter_level: number;

        /**
         * Creates a new U_UP_CHAPTER instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_UP_CHAPTER instance
         */
        public static create(properties?: chapter.IU_UP_CHAPTER): chapter.U_UP_CHAPTER;

        /**
         * Encodes the specified U_UP_CHAPTER message. Does not implicitly {@link chapter.U_UP_CHAPTER.verify|verify} messages.
         * @param message U_UP_CHAPTER message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: chapter.IU_UP_CHAPTER, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_UP_CHAPTER message, length delimited. Does not implicitly {@link chapter.U_UP_CHAPTER.verify|verify} messages.
         * @param message U_UP_CHAPTER message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: chapter.IU_UP_CHAPTER, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_UP_CHAPTER message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_UP_CHAPTER
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): chapter.U_UP_CHAPTER;

        /**
         * Decodes a U_UP_CHAPTER message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_UP_CHAPTER
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): chapter.U_UP_CHAPTER;

        /**
         * Verifies a U_UP_CHAPTER message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace common. */
declare namespace common {

    /** Properties of a RES. */
    interface IRES {

        /** RES type */
        type?: (number|null);

        /** RES id */
        id?: (number|null);

        /** RES count */
        count?: (number|Long|null);
    }

    /** Represents a RES. */
    class RES implements IRES {

        /**
         * Constructs a new RES.
         * @param [properties] Properties to set
         */
        constructor(properties?: common.IRES);

        /** RES type. */
        public type: number;

        /** RES id. */
        public id: number;

        /** RES count. */
        public count: (number|Long);

        /**
         * Creates a new RES instance using the specified properties.
         * @param [properties] Properties to set
         * @returns RES instance
         */
        public static create(properties?: common.IRES): common.RES;

        /**
         * Encodes the specified RES message. Does not implicitly {@link common.RES.verify|verify} messages.
         * @param message RES message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: common.IRES, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified RES message, length delimited. Does not implicitly {@link common.RES.verify|verify} messages.
         * @param message RES message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: common.IRES, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a RES message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns RES
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): common.RES;

        /**
         * Decodes a RES message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns RES
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): common.RES;

        /**
         * Verifies a RES message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace currency. */
declare namespace currency {

    /** Properties of a MONEY. */
    interface IMONEY {

        /** MONEY count */
        count?: (number|Long|null);

        /** MONEY big_count */
        big_count?: (string|null);
    }

    /** Represents a MONEY. */
    class MONEY implements IMONEY {

        /**
         * Constructs a new MONEY.
         * @param [properties] Properties to set
         */
        constructor(properties?: currency.IMONEY);

        /** MONEY count. */
        public count: (number|Long);

        /** MONEY big_count. */
        public big_count: string;

        /**
         * Creates a new MONEY instance using the specified properties.
         * @param [properties] Properties to set
         * @returns MONEY instance
         */
        public static create(properties?: currency.IMONEY): currency.MONEY;

        /**
         * Encodes the specified MONEY message. Does not implicitly {@link currency.MONEY.verify|verify} messages.
         * @param message MONEY message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: currency.IMONEY, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified MONEY message, length delimited. Does not implicitly {@link currency.MONEY.verify|verify} messages.
         * @param message MONEY message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: currency.IMONEY, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a MONEY message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns MONEY
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): currency.MONEY;

        /**
         * Decodes a MONEY message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns MONEY
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): currency.MONEY;

        /**
         * Verifies a MONEY message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO moneys */
        moneys?: ({ [k: string]: currency.IMONEY }|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: currency.IG_INFO);

        /** G_INFO moneys. */
        public moneys: { [k: string]: currency.IMONEY };

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: currency.IG_INFO): currency.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link currency.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: currency.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link currency.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: currency.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): currency.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): currency.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_UP_BIG. */
    interface IU_UP_BIG {

        /** U_UP_BIG bigs */
        bigs?: ({ [k: string]: string }|null);
    }

    /** Represents a U_UP_BIG. */
    class U_UP_BIG implements IU_UP_BIG {

        /**
         * Constructs a new U_UP_BIG.
         * @param [properties] Properties to set
         */
        constructor(properties?: currency.IU_UP_BIG);

        /** U_UP_BIG bigs. */
        public bigs: { [k: string]: string };

        /**
         * Creates a new U_UP_BIG instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_UP_BIG instance
         */
        public static create(properties?: currency.IU_UP_BIG): currency.U_UP_BIG;

        /**
         * Encodes the specified U_UP_BIG message. Does not implicitly {@link currency.U_UP_BIG.verify|verify} messages.
         * @param message U_UP_BIG message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: currency.IU_UP_BIG, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_UP_BIG message, length delimited. Does not implicitly {@link currency.U_UP_BIG.verify|verify} messages.
         * @param message U_UP_BIG message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: currency.IU_UP_BIG, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_UP_BIG message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_UP_BIG
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): currency.U_UP_BIG;

        /**
         * Decodes a U_UP_BIG message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_UP_BIG
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): currency.U_UP_BIG;

        /**
         * Verifies a U_UP_BIG message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_CHECK_DIAMOND. */
    interface IU_CHECK_DIAMOND {

        /** U_CHECK_DIAMOND count */
        count?: (number|Long|null);
    }

    /** Represents a U_CHECK_DIAMOND. */
    class U_CHECK_DIAMOND implements IU_CHECK_DIAMOND {

        /**
         * Constructs a new U_CHECK_DIAMOND.
         * @param [properties] Properties to set
         */
        constructor(properties?: currency.IU_CHECK_DIAMOND);

        /** U_CHECK_DIAMOND count. */
        public count: (number|Long);

        /**
         * Creates a new U_CHECK_DIAMOND instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_CHECK_DIAMOND instance
         */
        public static create(properties?: currency.IU_CHECK_DIAMOND): currency.U_CHECK_DIAMOND;

        /**
         * Encodes the specified U_CHECK_DIAMOND message. Does not implicitly {@link currency.U_CHECK_DIAMOND.verify|verify} messages.
         * @param message U_CHECK_DIAMOND message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: currency.IU_CHECK_DIAMOND, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_CHECK_DIAMOND message, length delimited. Does not implicitly {@link currency.U_CHECK_DIAMOND.verify|verify} messages.
         * @param message U_CHECK_DIAMOND message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: currency.IU_CHECK_DIAMOND, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_CHECK_DIAMOND message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_CHECK_DIAMOND
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): currency.U_CHECK_DIAMOND;

        /**
         * Decodes a U_CHECK_DIAMOND message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_CHECK_DIAMOND
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): currency.U_CHECK_DIAMOND;

        /**
         * Verifies a U_CHECK_DIAMOND message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace dailyad. */
declare namespace dailyad {

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO daily_count */
        daily_count?: (number|null);

        /** G_INFO reward_index */
        reward_index?: (number|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: dailyad.IG_INFO);

        /** G_INFO daily_count. */
        public daily_count: number;

        /** G_INFO reward_index. */
        public reward_index: number;

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: dailyad.IG_INFO): dailyad.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link dailyad.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dailyad.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link dailyad.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dailyad.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dailyad.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dailyad.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_ADD. */
    interface IU_ADD {

        /** U_ADD add_count */
        add_count?: (number|null);
    }

    /** Represents a U_ADD. */
    class U_ADD implements IU_ADD {

        /**
         * Constructs a new U_ADD.
         * @param [properties] Properties to set
         */
        constructor(properties?: dailyad.IU_ADD);

        /** U_ADD add_count. */
        public add_count: number;

        /**
         * Creates a new U_ADD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_ADD instance
         */
        public static create(properties?: dailyad.IU_ADD): dailyad.U_ADD;

        /**
         * Encodes the specified U_ADD message. Does not implicitly {@link dailyad.U_ADD.verify|verify} messages.
         * @param message U_ADD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dailyad.IU_ADD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_ADD message, length delimited. Does not implicitly {@link dailyad.U_ADD.verify|verify} messages.
         * @param message U_ADD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dailyad.IU_ADD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_ADD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_ADD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dailyad.U_ADD;

        /**
         * Decodes a U_ADD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_ADD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dailyad.U_ADD;

        /**
         * Verifies a U_ADD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_REWARD. */
    interface IU_REWARD {

        /** U_REWARD reward_index */
        reward_index?: (number|null);
    }

    /** Represents a U_REWARD. */
    class U_REWARD implements IU_REWARD {

        /**
         * Constructs a new U_REWARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: dailyad.IU_REWARD);

        /** U_REWARD reward_index. */
        public reward_index: number;

        /**
         * Creates a new U_REWARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_REWARD instance
         */
        public static create(properties?: dailyad.IU_REWARD): dailyad.U_REWARD;

        /**
         * Encodes the specified U_REWARD message. Does not implicitly {@link dailyad.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dailyad.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_REWARD message, length delimited. Does not implicitly {@link dailyad.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dailyad.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dailyad.U_REWARD;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dailyad.U_REWARD;

        /**
         * Verifies a U_REWARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace dailydiscount. */
declare namespace dailydiscount {

    /** Properties of a GOOD. */
    interface IGOOD {

        /** GOOD discount */
        discount?: (number|null);

        /** GOOD isbuy */
        isbuy?: (boolean|null);
    }

    /** Represents a GOOD. */
    class GOOD implements IGOOD {

        /**
         * Constructs a new GOOD.
         * @param [properties] Properties to set
         */
        constructor(properties?: dailydiscount.IGOOD);

        /** GOOD discount. */
        public discount: number;

        /** GOOD isbuy. */
        public isbuy: boolean;

        /**
         * Creates a new GOOD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns GOOD instance
         */
        public static create(properties?: dailydiscount.IGOOD): dailydiscount.GOOD;

        /**
         * Encodes the specified GOOD message. Does not implicitly {@link dailydiscount.GOOD.verify|verify} messages.
         * @param message GOOD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dailydiscount.IGOOD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified GOOD message, length delimited. Does not implicitly {@link dailydiscount.GOOD.verify|verify} messages.
         * @param message GOOD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dailydiscount.IGOOD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a GOOD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns GOOD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dailydiscount.GOOD;

        /**
         * Decodes a GOOD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns GOOD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dailydiscount.GOOD;

        /**
         * Verifies a GOOD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO daily_count */
        daily_count?: (number|null);

        /** G_INFO goods */
        goods?: ({ [k: string]: dailydiscount.IGOOD }|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: dailydiscount.IG_INFO);

        /** G_INFO daily_count. */
        public daily_count: number;

        /** G_INFO goods. */
        public goods: { [k: string]: dailydiscount.IGOOD };

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: dailydiscount.IG_INFO): dailydiscount.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link dailydiscount.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dailydiscount.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link dailydiscount.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dailydiscount.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dailydiscount.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dailydiscount.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_FLUSH. */
    interface IU_FLUSH {

        /** U_FLUSH goods */
        goods?: ({ [k: string]: number }|null);
    }

    /** Represents a U_FLUSH. */
    class U_FLUSH implements IU_FLUSH {

        /**
         * Constructs a new U_FLUSH.
         * @param [properties] Properties to set
         */
        constructor(properties?: dailydiscount.IU_FLUSH);

        /** U_FLUSH goods. */
        public goods: { [k: string]: number };

        /**
         * Creates a new U_FLUSH instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_FLUSH instance
         */
        public static create(properties?: dailydiscount.IU_FLUSH): dailydiscount.U_FLUSH;

        /**
         * Encodes the specified U_FLUSH message. Does not implicitly {@link dailydiscount.U_FLUSH.verify|verify} messages.
         * @param message U_FLUSH message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dailydiscount.IU_FLUSH, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_FLUSH message, length delimited. Does not implicitly {@link dailydiscount.U_FLUSH.verify|verify} messages.
         * @param message U_FLUSH message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dailydiscount.IU_FLUSH, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_FLUSH message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_FLUSH
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dailydiscount.U_FLUSH;

        /**
         * Decodes a U_FLUSH message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_FLUSH
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dailydiscount.U_FLUSH;

        /**
         * Verifies a U_FLUSH message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_BUY. */
    interface IU_BUY {

        /** U_BUY id */
        id?: (number|null);
    }

    /** Represents a U_BUY. */
    class U_BUY implements IU_BUY {

        /**
         * Constructs a new U_BUY.
         * @param [properties] Properties to set
         */
        constructor(properties?: dailydiscount.IU_BUY);

        /** U_BUY id. */
        public id: number;

        /**
         * Creates a new U_BUY instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_BUY instance
         */
        public static create(properties?: dailydiscount.IU_BUY): dailydiscount.U_BUY;

        /**
         * Encodes the specified U_BUY message. Does not implicitly {@link dailydiscount.U_BUY.verify|verify} messages.
         * @param message U_BUY message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dailydiscount.IU_BUY, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_BUY message, length delimited. Does not implicitly {@link dailydiscount.U_BUY.verify|verify} messages.
         * @param message U_BUY message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dailydiscount.IU_BUY, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_BUY message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_BUY
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dailydiscount.U_BUY;

        /**
         * Decodes a U_BUY message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_BUY
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dailydiscount.U_BUY;

        /**
         * Verifies a U_BUY message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace dice. */
declare namespace dice {

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO chapter */
        chapter?: (number|null);

        /** G_INFO inject */
        inject?: (number|null);

        /** G_INFO time */
        time?: (number|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: dice.IG_INFO);

        /** G_INFO chapter. */
        public chapter: number;

        /** G_INFO inject. */
        public inject: number;

        /** G_INFO time. */
        public time: number;

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: dice.IG_INFO): dice.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link dice.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dice.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link dice.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dice.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dice.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dice.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_INJECT. */
    interface IU_INJECT {

        /** U_INJECT inject */
        inject?: (number|null);
    }

    /** Represents a U_INJECT. */
    class U_INJECT implements IU_INJECT {

        /**
         * Constructs a new U_INJECT.
         * @param [properties] Properties to set
         */
        constructor(properties?: dice.IU_INJECT);

        /** U_INJECT inject. */
        public inject: number;

        /**
         * Creates a new U_INJECT instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_INJECT instance
         */
        public static create(properties?: dice.IU_INJECT): dice.U_INJECT;

        /**
         * Encodes the specified U_INJECT message. Does not implicitly {@link dice.U_INJECT.verify|verify} messages.
         * @param message U_INJECT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dice.IU_INJECT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_INJECT message, length delimited. Does not implicitly {@link dice.U_INJECT.verify|verify} messages.
         * @param message U_INJECT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dice.IU_INJECT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_INJECT message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_INJECT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dice.U_INJECT;

        /**
         * Decodes a U_INJECT message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_INJECT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dice.U_INJECT;

        /**
         * Verifies a U_INJECT message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_REWARD. */
    interface IU_REWARD {
    }

    /** Represents a U_REWARD. */
    class U_REWARD implements IU_REWARD {

        /**
         * Constructs a new U_REWARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: dice.IU_REWARD);

        /**
         * Creates a new U_REWARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_REWARD instance
         */
        public static create(properties?: dice.IU_REWARD): dice.U_REWARD;

        /**
         * Encodes the specified U_REWARD message. Does not implicitly {@link dice.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dice.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_REWARD message, length delimited. Does not implicitly {@link dice.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dice.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dice.U_REWARD;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dice.U_REWARD;

        /**
         * Verifies a U_REWARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_GATHER. */
    interface IU_GATHER {

        /** U_GATHER is_diamond */
        is_diamond?: (boolean|null);

        /** U_GATHER time */
        time?: (number|null);
    }

    /** Represents a U_GATHER. */
    class U_GATHER implements IU_GATHER {

        /**
         * Constructs a new U_GATHER.
         * @param [properties] Properties to set
         */
        constructor(properties?: dice.IU_GATHER);

        /** U_GATHER is_diamond. */
        public is_diamond: boolean;

        /** U_GATHER time. */
        public time: number;

        /**
         * Creates a new U_GATHER instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_GATHER instance
         */
        public static create(properties?: dice.IU_GATHER): dice.U_GATHER;

        /**
         * Encodes the specified U_GATHER message. Does not implicitly {@link dice.U_GATHER.verify|verify} messages.
         * @param message U_GATHER message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dice.IU_GATHER, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_GATHER message, length delimited. Does not implicitly {@link dice.U_GATHER.verify|verify} messages.
         * @param message U_GATHER message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dice.IU_GATHER, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_GATHER message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_GATHER
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dice.U_GATHER;

        /**
         * Decodes a U_GATHER message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_GATHER
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dice.U_GATHER;

        /**
         * Verifies a U_GATHER message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_REVIVAL. */
    interface IU_REVIVAL {
    }

    /** Represents a U_REVIVAL. */
    class U_REVIVAL implements IU_REVIVAL {

        /**
         * Constructs a new U_REVIVAL.
         * @param [properties] Properties to set
         */
        constructor(properties?: dice.IU_REVIVAL);

        /**
         * Creates a new U_REVIVAL instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_REVIVAL instance
         */
        public static create(properties?: dice.IU_REVIVAL): dice.U_REVIVAL;

        /**
         * Encodes the specified U_REVIVAL message. Does not implicitly {@link dice.U_REVIVAL.verify|verify} messages.
         * @param message U_REVIVAL message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dice.IU_REVIVAL, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_REVIVAL message, length delimited. Does not implicitly {@link dice.U_REVIVAL.verify|verify} messages.
         * @param message U_REVIVAL message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dice.IU_REVIVAL, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_REVIVAL message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_REVIVAL
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dice.U_REVIVAL;

        /**
         * Decodes a U_REVIVAL message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_REVIVAL
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dice.U_REVIVAL;

        /**
         * Verifies a U_REVIVAL message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_DOT. */
    interface IU_DOT {

        /** U_DOT chapter */
        chapter?: (number|null);

        /** U_DOT total_time */
        total_time?: (number|null);

        /** U_DOT dice_count */
        dice_count?: (number|null);

        /** U_DOT ad_reborn */
        ad_reborn?: (number|null);

        /** U_DOT diamond_reborn */
        diamond_reborn?: (number|null);

        /** U_DOT luck_dice_count */
        luck_dice_count?: (number|null);
    }

    /** Represents a U_DOT. */
    class U_DOT implements IU_DOT {

        /**
         * Constructs a new U_DOT.
         * @param [properties] Properties to set
         */
        constructor(properties?: dice.IU_DOT);

        /** U_DOT chapter. */
        public chapter: number;

        /** U_DOT total_time. */
        public total_time: number;

        /** U_DOT dice_count. */
        public dice_count: number;

        /** U_DOT ad_reborn. */
        public ad_reborn: number;

        /** U_DOT diamond_reborn. */
        public diamond_reborn: number;

        /** U_DOT luck_dice_count. */
        public luck_dice_count: number;

        /**
         * Creates a new U_DOT instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_DOT instance
         */
        public static create(properties?: dice.IU_DOT): dice.U_DOT;

        /**
         * Encodes the specified U_DOT message. Does not implicitly {@link dice.U_DOT.verify|verify} messages.
         * @param message U_DOT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: dice.IU_DOT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_DOT message, length delimited. Does not implicitly {@link dice.U_DOT.verify|verify} messages.
         * @param message U_DOT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: dice.IU_DOT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_DOT message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_DOT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): dice.U_DOT;

        /**
         * Decodes a U_DOT message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_DOT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): dice.U_DOT;

        /**
         * Verifies a U_DOT message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace event. */
declare namespace event {

    /** Properties of a U_DOT. */
    interface IU_DOT {

        /** U_DOT event_id */
        event_id?: (number|null);

        /** U_DOT count */
        count?: (number|null);
    }

    /** Represents a U_DOT. */
    class U_DOT implements IU_DOT {

        /**
         * Constructs a new U_DOT.
         * @param [properties] Properties to set
         */
        constructor(properties?: event.IU_DOT);

        /** U_DOT event_id. */
        public event_id: number;

        /** U_DOT count. */
        public count: number;

        /**
         * Creates a new U_DOT instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_DOT instance
         */
        public static create(properties?: event.IU_DOT): event.U_DOT;

        /**
         * Encodes the specified U_DOT message. Does not implicitly {@link event.U_DOT.verify|verify} messages.
         * @param message U_DOT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: event.IU_DOT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_DOT message, length delimited. Does not implicitly {@link event.U_DOT.verify|verify} messages.
         * @param message U_DOT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: event.IU_DOT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_DOT message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_DOT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): event.U_DOT;

        /**
         * Decodes a U_DOT message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_DOT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): event.U_DOT;

        /**
         * Verifies a U_DOT message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace gift. */
declare namespace gift {

    /** Properties of a GIFT. */
    interface IGIFT {

        /** GIFT buy_count */
        buy_count?: (number|null);

        /** GIFT buy_time */
        buy_time?: (number|Long|null);

        /** GIFT etime */
        etime?: (number|Long|null);
    }

    /** Represents a GIFT. */
    class GIFT implements IGIFT {

        /**
         * Constructs a new GIFT.
         * @param [properties] Properties to set
         */
        constructor(properties?: gift.IGIFT);

        /** GIFT buy_count. */
        public buy_count: number;

        /** GIFT buy_time. */
        public buy_time: (number|Long);

        /** GIFT etime. */
        public etime: (number|Long);

        /**
         * Creates a new GIFT instance using the specified properties.
         * @param [properties] Properties to set
         * @returns GIFT instance
         */
        public static create(properties?: gift.IGIFT): gift.GIFT;

        /**
         * Encodes the specified GIFT message. Does not implicitly {@link gift.GIFT.verify|verify} messages.
         * @param message GIFT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: gift.IGIFT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified GIFT message, length delimited. Does not implicitly {@link gift.GIFT.verify|verify} messages.
         * @param message GIFT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: gift.IGIFT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a GIFT message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns GIFT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): gift.GIFT;

        /**
         * Decodes a GIFT message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns GIFT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): gift.GIFT;

        /**
         * Verifies a GIFT message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO gifts */
        gifts?: ({ [k: string]: gift.IGIFT }|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: gift.IG_INFO);

        /** G_INFO gifts. */
        public gifts: { [k: string]: gift.IGIFT };

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: gift.IG_INFO): gift.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link gift.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: gift.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link gift.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: gift.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): gift.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): gift.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_ETIME. */
    interface IU_ETIME {

        /** U_ETIME id */
        id?: (number|null);

        /** U_ETIME etime */
        etime?: (number|Long|null);
    }

    /** Represents a U_ETIME. */
    class U_ETIME implements IU_ETIME {

        /**
         * Constructs a new U_ETIME.
         * @param [properties] Properties to set
         */
        constructor(properties?: gift.IU_ETIME);

        /** U_ETIME id. */
        public id: number;

        /** U_ETIME etime. */
        public etime: (number|Long);

        /**
         * Creates a new U_ETIME instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_ETIME instance
         */
        public static create(properties?: gift.IU_ETIME): gift.U_ETIME;

        /**
         * Encodes the specified U_ETIME message. Does not implicitly {@link gift.U_ETIME.verify|verify} messages.
         * @param message U_ETIME message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: gift.IU_ETIME, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_ETIME message, length delimited. Does not implicitly {@link gift.U_ETIME.verify|verify} messages.
         * @param message U_ETIME message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: gift.IU_ETIME, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_ETIME message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_ETIME
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): gift.U_ETIME;

        /**
         * Decodes a U_ETIME message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_ETIME
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): gift.U_ETIME;

        /**
         * Verifies a U_ETIME message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace guide. */
declare namespace guide {

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO group_id */
        group_id?: (number|null);

        /** G_INFO step_id */
        step_id?: (number|null);

        /** G_INFO completes */
        completes?: ((number|Long)[]|null);

        /** G_INFO reward */
        reward?: (number|Long|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: guide.IG_INFO);

        /** G_INFO group_id. */
        public group_id: number;

        /** G_INFO step_id. */
        public step_id: number;

        /** G_INFO completes. */
        public completes: (number|Long)[];

        /** G_INFO reward. */
        public reward: (number|Long);

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: guide.IG_INFO): guide.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link guide.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: guide.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link guide.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: guide.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): guide.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): guide.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_UPDATE. */
    interface IU_UPDATE {

        /** U_UPDATE group_id */
        group_id?: (number|null);

        /** U_UPDATE step_id */
        step_id?: (number|null);
    }

    /** Represents a U_UPDATE. */
    class U_UPDATE implements IU_UPDATE {

        /**
         * Constructs a new U_UPDATE.
         * @param [properties] Properties to set
         */
        constructor(properties?: guide.IU_UPDATE);

        /** U_UPDATE group_id. */
        public group_id: number;

        /** U_UPDATE step_id. */
        public step_id: number;

        /**
         * Creates a new U_UPDATE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_UPDATE instance
         */
        public static create(properties?: guide.IU_UPDATE): guide.U_UPDATE;

        /**
         * Encodes the specified U_UPDATE message. Does not implicitly {@link guide.U_UPDATE.verify|verify} messages.
         * @param message U_UPDATE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: guide.IU_UPDATE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_UPDATE message, length delimited. Does not implicitly {@link guide.U_UPDATE.verify|verify} messages.
         * @param message U_UPDATE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: guide.IU_UPDATE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_UPDATE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_UPDATE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): guide.U_UPDATE;

        /**
         * Decodes a U_UPDATE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_UPDATE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): guide.U_UPDATE;

        /**
         * Verifies a U_UPDATE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_WEAK_DOT. */
    interface IU_WEAK_DOT {

        /** U_WEAK_DOT guide_id */
        guide_id?: (number|null);
    }

    /** Represents a U_WEAK_DOT. */
    class U_WEAK_DOT implements IU_WEAK_DOT {

        /**
         * Constructs a new U_WEAK_DOT.
         * @param [properties] Properties to set
         */
        constructor(properties?: guide.IU_WEAK_DOT);

        /** U_WEAK_DOT guide_id. */
        public guide_id: number;

        /**
         * Creates a new U_WEAK_DOT instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_WEAK_DOT instance
         */
        public static create(properties?: guide.IU_WEAK_DOT): guide.U_WEAK_DOT;

        /**
         * Encodes the specified U_WEAK_DOT message. Does not implicitly {@link guide.U_WEAK_DOT.verify|verify} messages.
         * @param message U_WEAK_DOT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: guide.IU_WEAK_DOT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_WEAK_DOT message, length delimited. Does not implicitly {@link guide.U_WEAK_DOT.verify|verify} messages.
         * @param message U_WEAK_DOT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: guide.IU_WEAK_DOT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_WEAK_DOT message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_WEAK_DOT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): guide.U_WEAK_DOT;

        /**
         * Decodes a U_WEAK_DOT message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_WEAK_DOT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): guide.U_WEAK_DOT;

        /**
         * Verifies a U_WEAK_DOT message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace item. */
declare namespace item {

    /** Properties of a ITEM. */
    interface IITEM {

        /** ITEM item_count */
        item_count?: (number|Long|null);

        /** ITEM open_count */
        open_count?: (number|Long|null);
    }

    /** Represents a ITEM. */
    class ITEM implements IITEM {

        /**
         * Constructs a new ITEM.
         * @param [properties] Properties to set
         */
        constructor(properties?: item.IITEM);

        /** ITEM item_count. */
        public item_count: (number|Long);

        /** ITEM open_count. */
        public open_count: (number|Long);

        /**
         * Creates a new ITEM instance using the specified properties.
         * @param [properties] Properties to set
         * @returns ITEM instance
         */
        public static create(properties?: item.IITEM): item.ITEM;

        /**
         * Encodes the specified ITEM message. Does not implicitly {@link item.ITEM.verify|verify} messages.
         * @param message ITEM message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: item.IITEM, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified ITEM message, length delimited. Does not implicitly {@link item.ITEM.verify|verify} messages.
         * @param message ITEM message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: item.IITEM, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a ITEM message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns ITEM
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): item.ITEM;

        /**
         * Decodes a ITEM message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns ITEM
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): item.ITEM;

        /**
         * Verifies a ITEM message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a GROUP. */
    interface IGROUP {

        /** GROUP group_id */
        group_id?: (number|null);

        /** GROUP drop_id */
        drop_id?: (number|null);

        /** GROUP count */
        count?: (number|null);

        /** GROUP big_count */
        big_count?: (string|null);
    }

    /** Represents a GROUP. */
    class GROUP implements IGROUP {

        /**
         * Constructs a new GROUP.
         * @param [properties] Properties to set
         */
        constructor(properties?: item.IGROUP);

        /** GROUP group_id. */
        public group_id: number;

        /** GROUP drop_id. */
        public drop_id: number;

        /** GROUP count. */
        public count: number;

        /** GROUP big_count. */
        public big_count: string;

        /**
         * Creates a new GROUP instance using the specified properties.
         * @param [properties] Properties to set
         * @returns GROUP instance
         */
        public static create(properties?: item.IGROUP): item.GROUP;

        /**
         * Encodes the specified GROUP message. Does not implicitly {@link item.GROUP.verify|verify} messages.
         * @param message GROUP message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: item.IGROUP, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified GROUP message, length delimited. Does not implicitly {@link item.GROUP.verify|verify} messages.
         * @param message GROUP message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: item.IGROUP, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a GROUP message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns GROUP
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): item.GROUP;

        /**
         * Decodes a GROUP message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns GROUP
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): item.GROUP;

        /**
         * Verifies a GROUP message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO items */
        items?: ({ [k: string]: item.IITEM }|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: item.IG_INFO);

        /** G_INFO items. */
        public items: { [k: string]: item.IITEM };

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: item.IG_INFO): item.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link item.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: item.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link item.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: item.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): item.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): item.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_OPEN. */
    interface IU_OPEN {

        /** U_OPEN item_id */
        item_id?: (number|null);

        /** U_OPEN open_count */
        open_count?: (number|null);

        /** U_OPEN groups */
        groups?: (item.IGROUP[]|null);
    }

    /** Represents a U_OPEN. */
    class U_OPEN implements IU_OPEN {

        /**
         * Constructs a new U_OPEN.
         * @param [properties] Properties to set
         */
        constructor(properties?: item.IU_OPEN);

        /** U_OPEN item_id. */
        public item_id: number;

        /** U_OPEN open_count. */
        public open_count: number;

        /** U_OPEN groups. */
        public groups: item.IGROUP[];

        /**
         * Creates a new U_OPEN instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_OPEN instance
         */
        public static create(properties?: item.IU_OPEN): item.U_OPEN;

        /**
         * Encodes the specified U_OPEN message. Does not implicitly {@link item.U_OPEN.verify|verify} messages.
         * @param message U_OPEN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: item.IU_OPEN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_OPEN message, length delimited. Does not implicitly {@link item.U_OPEN.verify|verify} messages.
         * @param message U_OPEN message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: item.IU_OPEN, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_OPEN message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_OPEN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): item.U_OPEN;

        /**
         * Decodes a U_OPEN message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_OPEN
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): item.U_OPEN;

        /**
         * Verifies a U_OPEN message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace level. */
declare namespace level {

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO level */
        level?: (number|null);

        /** G_INFO exp */
        exp?: (number|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: level.IG_INFO);

        /** G_INFO level. */
        public level: number;

        /** G_INFO exp. */
        public exp: number;

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: level.IG_INFO): level.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link level.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: level.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link level.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: level.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): level.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): level.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace offline. */
declare namespace offline {

    /** Properties of a U_REWARD. */
    interface IU_REWARD {
    }

    /** Represents a U_REWARD. */
    class U_REWARD implements IU_REWARD {

        /**
         * Constructs a new U_REWARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: offline.IU_REWARD);

        /**
         * Creates a new U_REWARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_REWARD instance
         */
        public static create(properties?: offline.IU_REWARD): offline.U_REWARD;

        /**
         * Encodes the specified U_REWARD message. Does not implicitly {@link offline.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: offline.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_REWARD message, length delimited. Does not implicitly {@link offline.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: offline.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): offline.U_REWARD;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): offline.U_REWARD;

        /**
         * Verifies a U_REWARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace other. */
declare namespace other {

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO sync_time */
        sync_time?: (number|Long|null);

        /** G_INFO backstage_time */
        backstage_time?: (number|Long|null);

        /** G_INFO unique_id */
        unique_id?: (number|Long|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: other.IG_INFO);

        /** G_INFO sync_time. */
        public sync_time: (number|Long);

        /** G_INFO backstage_time. */
        public backstage_time: (number|Long);

        /** G_INFO unique_id. */
        public unique_id: (number|Long);

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: other.IG_INFO): other.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link other.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: other.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link other.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: other.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): other.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): other.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_BACKSTAGE. */
    interface IU_BACKSTAGE {

        /** U_BACKSTAGE backstage_time */
        backstage_time?: (number|Long|null);
    }

    /** Represents a U_BACKSTAGE. */
    class U_BACKSTAGE implements IU_BACKSTAGE {

        /**
         * Constructs a new U_BACKSTAGE.
         * @param [properties] Properties to set
         */
        constructor(properties?: other.IU_BACKSTAGE);

        /** U_BACKSTAGE backstage_time. */
        public backstage_time: (number|Long);

        /**
         * Creates a new U_BACKSTAGE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_BACKSTAGE instance
         */
        public static create(properties?: other.IU_BACKSTAGE): other.U_BACKSTAGE;

        /**
         * Encodes the specified U_BACKSTAGE message. Does not implicitly {@link other.U_BACKSTAGE.verify|verify} messages.
         * @param message U_BACKSTAGE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: other.IU_BACKSTAGE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_BACKSTAGE message, length delimited. Does not implicitly {@link other.U_BACKSTAGE.verify|verify} messages.
         * @param message U_BACKSTAGE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: other.IU_BACKSTAGE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_BACKSTAGE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_BACKSTAGE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): other.U_BACKSTAGE;

        /**
         * Decodes a U_BACKSTAGE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_BACKSTAGE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): other.U_BACKSTAGE;

        /**
         * Verifies a U_BACKSTAGE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace recharge. */
declare namespace recharge {

    /** Properties of a WAIT. */
    interface IWAIT {

        /** WAIT rechargeid */
        rechargeid?: (number|null);

        /** WAIT count */
        count?: (number|null);
    }

    /** Represents a WAIT. */
    class WAIT implements IWAIT {

        /**
         * Constructs a new WAIT.
         * @param [properties] Properties to set
         */
        constructor(properties?: recharge.IWAIT);

        /** WAIT rechargeid. */
        public rechargeid: number;

        /** WAIT count. */
        public count: number;

        /**
         * Creates a new WAIT instance using the specified properties.
         * @param [properties] Properties to set
         * @returns WAIT instance
         */
        public static create(properties?: recharge.IWAIT): recharge.WAIT;

        /**
         * Encodes the specified WAIT message. Does not implicitly {@link recharge.WAIT.verify|verify} messages.
         * @param message WAIT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: recharge.IWAIT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified WAIT message, length delimited. Does not implicitly {@link recharge.WAIT.verify|verify} messages.
         * @param message WAIT message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: recharge.IWAIT, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a WAIT message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns WAIT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): recharge.WAIT;

        /**
         * Decodes a WAIT message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns WAIT
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): recharge.WAIT;

        /**
         * Verifies a WAIT message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO waits */
        waits?: (recharge.IWAIT[]|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: recharge.IG_INFO);

        /** G_INFO waits. */
        public waits: recharge.IWAIT[];

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: recharge.IG_INFO): recharge.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link recharge.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: recharge.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link recharge.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: recharge.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): recharge.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): recharge.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_ORDER. */
    interface IU_ORDER {

        /** U_ORDER rechargeid */
        rechargeid?: (number|null);
    }

    /** Represents a U_ORDER. */
    class U_ORDER implements IU_ORDER {

        /**
         * Constructs a new U_ORDER.
         * @param [properties] Properties to set
         */
        constructor(properties?: recharge.IU_ORDER);

        /** U_ORDER rechargeid. */
        public rechargeid: number;

        /**
         * Creates a new U_ORDER instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_ORDER instance
         */
        public static create(properties?: recharge.IU_ORDER): recharge.U_ORDER;

        /**
         * Encodes the specified U_ORDER message. Does not implicitly {@link recharge.U_ORDER.verify|verify} messages.
         * @param message U_ORDER message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: recharge.IU_ORDER, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_ORDER message, length delimited. Does not implicitly {@link recharge.U_ORDER.verify|verify} messages.
         * @param message U_ORDER message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: recharge.IU_ORDER, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_ORDER message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_ORDER
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): recharge.U_ORDER;

        /**
         * Decodes a U_ORDER message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_ORDER
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): recharge.U_ORDER;

        /**
         * Verifies a U_ORDER message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_ORDER. */
    interface IG_ORDER {

        /** G_ORDER succ */
        succ?: (boolean|null);

        /** G_ORDER rechargeid */
        rechargeid?: (number|null);

        /** G_ORDER account_id */
        account_id?: (string|null);

        /** G_ORDER profile_id */
        profile_id?: (string|null);
    }

    /** Represents a G_ORDER. */
    class G_ORDER implements IG_ORDER {

        /**
         * Constructs a new G_ORDER.
         * @param [properties] Properties to set
         */
        constructor(properties?: recharge.IG_ORDER);

        /** G_ORDER succ. */
        public succ: boolean;

        /** G_ORDER rechargeid. */
        public rechargeid: number;

        /** G_ORDER account_id. */
        public account_id: string;

        /** G_ORDER profile_id. */
        public profile_id: string;

        /**
         * Creates a new G_ORDER instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_ORDER instance
         */
        public static create(properties?: recharge.IG_ORDER): recharge.G_ORDER;

        /**
         * Encodes the specified G_ORDER message. Does not implicitly {@link recharge.G_ORDER.verify|verify} messages.
         * @param message G_ORDER message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: recharge.IG_ORDER, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_ORDER message, length delimited. Does not implicitly {@link recharge.G_ORDER.verify|verify} messages.
         * @param message G_ORDER message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: recharge.IG_ORDER, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_ORDER message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_ORDER
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): recharge.G_ORDER;

        /**
         * Decodes a G_ORDER message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_ORDER
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): recharge.G_ORDER;

        /**
         * Verifies a G_ORDER message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_CALLBACK. */
    interface IU_CALLBACK {

        /** U_CALLBACK platformid */
        platformid?: (number|null);

        /** U_CALLBACK signature */
        signature?: (string|null);

        /** U_CALLBACK signature_data */
        signature_data?: (string|null);

        /** U_CALLBACK receipt */
        receipt?: (string|null);
    }

    /** Represents a U_CALLBACK. */
    class U_CALLBACK implements IU_CALLBACK {

        /**
         * Constructs a new U_CALLBACK.
         * @param [properties] Properties to set
         */
        constructor(properties?: recharge.IU_CALLBACK);

        /** U_CALLBACK platformid. */
        public platformid: number;

        /** U_CALLBACK signature. */
        public signature: string;

        /** U_CALLBACK signature_data. */
        public signature_data: string;

        /** U_CALLBACK receipt. */
        public receipt: string;

        /**
         * Creates a new U_CALLBACK instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_CALLBACK instance
         */
        public static create(properties?: recharge.IU_CALLBACK): recharge.U_CALLBACK;

        /**
         * Encodes the specified U_CALLBACK message. Does not implicitly {@link recharge.U_CALLBACK.verify|verify} messages.
         * @param message U_CALLBACK message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: recharge.IU_CALLBACK, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_CALLBACK message, length delimited. Does not implicitly {@link recharge.U_CALLBACK.verify|verify} messages.
         * @param message U_CALLBACK message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: recharge.IU_CALLBACK, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_CALLBACK message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_CALLBACK
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): recharge.U_CALLBACK;

        /**
         * Decodes a U_CALLBACK message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_CALLBACK
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): recharge.U_CALLBACK;

        /**
         * Verifies a U_CALLBACK message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_CALLBACK. */
    interface IG_CALLBACK {

        /** G_CALLBACK succ */
        succ?: (boolean|null);

        /** G_CALLBACK rechargeid */
        rechargeid?: (number|null);

        /** G_CALLBACK isdev */
        isdev?: (boolean|null);

        /** G_CALLBACK receipt */
        receipt?: (string|null);
    }

    /** Represents a G_CALLBACK. */
    class G_CALLBACK implements IG_CALLBACK {

        /**
         * Constructs a new G_CALLBACK.
         * @param [properties] Properties to set
         */
        constructor(properties?: recharge.IG_CALLBACK);

        /** G_CALLBACK succ. */
        public succ: boolean;

        /** G_CALLBACK rechargeid. */
        public rechargeid: number;

        /** G_CALLBACK isdev. */
        public isdev: boolean;

        /** G_CALLBACK receipt. */
        public receipt: string;

        /**
         * Creates a new G_CALLBACK instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_CALLBACK instance
         */
        public static create(properties?: recharge.IG_CALLBACK): recharge.G_CALLBACK;

        /**
         * Encodes the specified G_CALLBACK message. Does not implicitly {@link recharge.G_CALLBACK.verify|verify} messages.
         * @param message G_CALLBACK message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: recharge.IG_CALLBACK, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_CALLBACK message, length delimited. Does not implicitly {@link recharge.G_CALLBACK.verify|verify} messages.
         * @param message G_CALLBACK message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: recharge.IG_CALLBACK, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_CALLBACK message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_CALLBACK
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): recharge.G_CALLBACK;

        /**
         * Decodes a G_CALLBACK message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_CALLBACK
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): recharge.G_CALLBACK;

        /**
         * Verifies a G_CALLBACK message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_REWARD. */
    interface IU_REWARD {

        /** U_REWARD rechargeid */
        rechargeid?: (number|null);

        /** U_REWARD time */
        time?: (number|Long|null);
    }

    /** Represents a U_REWARD. */
    class U_REWARD implements IU_REWARD {

        /**
         * Constructs a new U_REWARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: recharge.IU_REWARD);

        /** U_REWARD rechargeid. */
        public rechargeid: number;

        /** U_REWARD time. */
        public time: (number|Long);

        /**
         * Creates a new U_REWARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_REWARD instance
         */
        public static create(properties?: recharge.IU_REWARD): recharge.U_REWARD;

        /**
         * Encodes the specified U_REWARD message. Does not implicitly {@link recharge.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: recharge.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_REWARD message, length delimited. Does not implicitly {@link recharge.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: recharge.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): recharge.U_REWARD;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): recharge.U_REWARD;

        /**
         * Verifies a U_REWARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace savingpot. */
declare namespace savingpot {

    /** Properties of a FUNC. */
    interface IFUNC {

        /** FUNC total */
        total?: (number|null);
    }

    /** Represents a FUNC. */
    class FUNC implements IFUNC {

        /**
         * Constructs a new FUNC.
         * @param [properties] Properties to set
         */
        constructor(properties?: savingpot.IFUNC);

        /** FUNC total. */
        public total: number;

        /**
         * Creates a new FUNC instance using the specified properties.
         * @param [properties] Properties to set
         * @returns FUNC instance
         */
        public static create(properties?: savingpot.IFUNC): savingpot.FUNC;

        /**
         * Encodes the specified FUNC message. Does not implicitly {@link savingpot.FUNC.verify|verify} messages.
         * @param message FUNC message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: savingpot.IFUNC, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified FUNC message, length delimited. Does not implicitly {@link savingpot.FUNC.verify|verify} messages.
         * @param message FUNC message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: savingpot.IFUNC, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a FUNC message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns FUNC
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): savingpot.FUNC;

        /**
         * Decodes a FUNC message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns FUNC
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): savingpot.FUNC;

        /**
         * Verifies a FUNC message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO level */
        level?: (number|null);

        /** G_INFO diamond */
        diamond?: (number|null);

        /** G_INFO time */
        time?: (number|null);

        /** G_INFO functions */
        functions?: ({ [k: string]: savingpot.IFUNC }|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: savingpot.IG_INFO);

        /** G_INFO level. */
        public level: number;

        /** G_INFO diamond. */
        public diamond: number;

        /** G_INFO time. */
        public time: number;

        /** G_INFO functions. */
        public functions: { [k: string]: savingpot.IFUNC };

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: savingpot.IG_INFO): savingpot.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link savingpot.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: savingpot.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link savingpot.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: savingpot.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): savingpot.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): savingpot.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_FULL. */
    interface IU_FULL {

        /** U_FULL time */
        time?: (number|null);

        /** U_FULL reset */
        reset?: (boolean|null);
    }

    /** Represents a U_FULL. */
    class U_FULL implements IU_FULL {

        /**
         * Constructs a new U_FULL.
         * @param [properties] Properties to set
         */
        constructor(properties?: savingpot.IU_FULL);

        /** U_FULL time. */
        public time: number;

        /** U_FULL reset. */
        public reset: boolean;

        /**
         * Creates a new U_FULL instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_FULL instance
         */
        public static create(properties?: savingpot.IU_FULL): savingpot.U_FULL;

        /**
         * Encodes the specified U_FULL message. Does not implicitly {@link savingpot.U_FULL.verify|verify} messages.
         * @param message U_FULL message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: savingpot.IU_FULL, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_FULL message, length delimited. Does not implicitly {@link savingpot.U_FULL.verify|verify} messages.
         * @param message U_FULL message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: savingpot.IU_FULL, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_FULL message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_FULL
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): savingpot.U_FULL;

        /**
         * Decodes a U_FULL message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_FULL
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): savingpot.U_FULL;

        /**
         * Verifies a U_FULL message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace shop. */
declare namespace shop {

    /** Properties of a SHOP. */
    interface ISHOP {

        /** SHOP buy_count */
        buy_count?: (number|null);

        /** SHOP total_count */
        total_count?: (number|null);

        /** SHOP buy_time */
        buy_time?: (number|Long|null);
    }

    /** Represents a SHOP. */
    class SHOP implements ISHOP {

        /**
         * Constructs a new SHOP.
         * @param [properties] Properties to set
         */
        constructor(properties?: shop.ISHOP);

        /** SHOP buy_count. */
        public buy_count: number;

        /** SHOP total_count. */
        public total_count: number;

        /** SHOP buy_time. */
        public buy_time: (number|Long);

        /**
         * Creates a new SHOP instance using the specified properties.
         * @param [properties] Properties to set
         * @returns SHOP instance
         */
        public static create(properties?: shop.ISHOP): shop.SHOP;

        /**
         * Encodes the specified SHOP message. Does not implicitly {@link shop.SHOP.verify|verify} messages.
         * @param message SHOP message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: shop.ISHOP, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified SHOP message, length delimited. Does not implicitly {@link shop.SHOP.verify|verify} messages.
         * @param message SHOP message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: shop.ISHOP, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a SHOP message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns SHOP
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): shop.SHOP;

        /**
         * Decodes a SHOP message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns SHOP
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): shop.SHOP;

        /**
         * Verifies a SHOP message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO shops */
        shops?: ({ [k: string]: shop.ISHOP }|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: shop.IG_INFO);

        /** G_INFO shops. */
        public shops: { [k: string]: shop.ISHOP };

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: shop.IG_INFO): shop.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link shop.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: shop.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link shop.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: shop.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): shop.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): shop.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_BUY. */
    interface IU_BUY {

        /** U_BUY id */
        id?: (number|null);

        /** U_BUY count */
        count?: (number|null);

        /** U_BUY time */
        time?: (number|Long|null);
    }

    /** Represents a U_BUY. */
    class U_BUY implements IU_BUY {

        /**
         * Constructs a new U_BUY.
         * @param [properties] Properties to set
         */
        constructor(properties?: shop.IU_BUY);

        /** U_BUY id. */
        public id: number;

        /** U_BUY count. */
        public count: number;

        /** U_BUY time. */
        public time: (number|Long);

        /**
         * Creates a new U_BUY instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_BUY instance
         */
        public static create(properties?: shop.IU_BUY): shop.U_BUY;

        /**
         * Encodes the specified U_BUY message. Does not implicitly {@link shop.U_BUY.verify|verify} messages.
         * @param message U_BUY message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: shop.IU_BUY, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_BUY message, length delimited. Does not implicitly {@link shop.U_BUY.verify|verify} messages.
         * @param message U_BUY message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: shop.IU_BUY, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_BUY message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_BUY
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): shop.U_BUY;

        /**
         * Decodes a U_BUY message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_BUY
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): shop.U_BUY;

        /**
         * Verifies a U_BUY message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace shopcard. */
declare namespace shopcard {

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO card_ids */
        card_ids?: (number[]|null);

        /** G_INFO total_count */
        total_count?: (number|null);

        /** G_INFO count */
        count?: (number|null);

        /** G_INFO last_time */
        last_time?: (number|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: shopcard.IG_INFO);

        /** G_INFO card_ids. */
        public card_ids: number[];

        /** G_INFO total_count. */
        public total_count: number;

        /** G_INFO count. */
        public count: number;

        /** G_INFO last_time. */
        public last_time: number;

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: shopcard.IG_INFO): shopcard.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link shopcard.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: shopcard.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link shopcard.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: shopcard.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): shopcard.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): shopcard.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_EXCHANGE. */
    interface IU_EXCHANGE {

        /** U_EXCHANGE count */
        count?: (number|null);

        /** U_EXCHANGE cards */
        cards?: ({ [k: string]: number }|null);
    }

    /** Represents a U_EXCHANGE. */
    class U_EXCHANGE implements IU_EXCHANGE {

        /**
         * Constructs a new U_EXCHANGE.
         * @param [properties] Properties to set
         */
        constructor(properties?: shopcard.IU_EXCHANGE);

        /** U_EXCHANGE count. */
        public count: number;

        /** U_EXCHANGE cards. */
        public cards: { [k: string]: number };

        /**
         * Creates a new U_EXCHANGE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_EXCHANGE instance
         */
        public static create(properties?: shopcard.IU_EXCHANGE): shopcard.U_EXCHANGE;

        /**
         * Encodes the specified U_EXCHANGE message. Does not implicitly {@link shopcard.U_EXCHANGE.verify|verify} messages.
         * @param message U_EXCHANGE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: shopcard.IU_EXCHANGE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_EXCHANGE message, length delimited. Does not implicitly {@link shopcard.U_EXCHANGE.verify|verify} messages.
         * @param message U_EXCHANGE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: shopcard.IU_EXCHANGE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_EXCHANGE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_EXCHANGE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): shopcard.U_EXCHANGE;

        /**
         * Decodes a U_EXCHANGE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_EXCHANGE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): shopcard.U_EXCHANGE;

        /**
         * Verifies a U_EXCHANGE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_REFRESH. */
    interface IU_REFRESH {

        /** U_REFRESH card_ids */
        card_ids?: (number[]|null);

        /** U_REFRESH is_diamond */
        is_diamond?: (boolean|null);

        /** U_REFRESH time */
        time?: (number|null);
    }

    /** Represents a U_REFRESH. */
    class U_REFRESH implements IU_REFRESH {

        /**
         * Constructs a new U_REFRESH.
         * @param [properties] Properties to set
         */
        constructor(properties?: shopcard.IU_REFRESH);

        /** U_REFRESH card_ids. */
        public card_ids: number[];

        /** U_REFRESH is_diamond. */
        public is_diamond: boolean;

        /** U_REFRESH time. */
        public time: number;

        /**
         * Creates a new U_REFRESH instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_REFRESH instance
         */
        public static create(properties?: shopcard.IU_REFRESH): shopcard.U_REFRESH;

        /**
         * Encodes the specified U_REFRESH message. Does not implicitly {@link shopcard.U_REFRESH.verify|verify} messages.
         * @param message U_REFRESH message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: shopcard.IU_REFRESH, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_REFRESH message, length delimited. Does not implicitly {@link shopcard.U_REFRESH.verify|verify} messages.
         * @param message U_REFRESH message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: shopcard.IU_REFRESH, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_REFRESH message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_REFRESH
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): shopcard.U_REFRESH;

        /**
         * Decodes a U_REFRESH message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_REFRESH
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): shopcard.U_REFRESH;

        /**
         * Verifies a U_REFRESH message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace task. */
declare namespace task {

    /** Properties of a TASK. */
    interface ITASK {

        /** TASK progress */
        progress?: (number|null);

        /** TASK big_progress */
        big_progress?: (string|null);
    }

    /** Represents a TASK. */
    class TASK implements ITASK {

        /**
         * Constructs a new TASK.
         * @param [properties] Properties to set
         */
        constructor(properties?: task.ITASK);

        /** TASK progress. */
        public progress: number;

        /** TASK big_progress. */
        public big_progress: string;

        /**
         * Creates a new TASK instance using the specified properties.
         * @param [properties] Properties to set
         * @returns TASK instance
         */
        public static create(properties?: task.ITASK): task.TASK;

        /**
         * Encodes the specified TASK message. Does not implicitly {@link task.TASK.verify|verify} messages.
         * @param message TASK message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: task.ITASK, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified TASK message, length delimited. Does not implicitly {@link task.TASK.verify|verify} messages.
         * @param message TASK message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: task.ITASK, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a TASK message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns TASK
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): task.TASK;

        /**
         * Decodes a TASK message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns TASK
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): task.TASK;

        /**
         * Verifies a TASK message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO sort_id */
        sort_id?: (number|null);

        /** G_INFO tasks */
        tasks?: ({ [k: string]: task.ITASK }|null);

        /** G_INFO stage_finish */
        stage_finish?: (number|null);

        /** G_INFO stage_index */
        stage_index?: (number|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: task.IG_INFO);

        /** G_INFO sort_id. */
        public sort_id: number;

        /** G_INFO tasks. */
        public tasks: { [k: string]: task.ITASK };

        /** G_INFO stage_finish. */
        public stage_finish: number;

        /** G_INFO stage_index. */
        public stage_index: number;

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: task.IG_INFO): task.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link task.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: task.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link task.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: task.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): task.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): task.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_SYNC_BIG. */
    interface IU_SYNC_BIG {

        /** U_SYNC_BIG task_id */
        task_id?: (number|null);

        /** U_SYNC_BIG big_progress */
        big_progress?: (string|null);
    }

    /** Represents a U_SYNC_BIG. */
    class U_SYNC_BIG implements IU_SYNC_BIG {

        /**
         * Constructs a new U_SYNC_BIG.
         * @param [properties] Properties to set
         */
        constructor(properties?: task.IU_SYNC_BIG);

        /** U_SYNC_BIG task_id. */
        public task_id: number;

        /** U_SYNC_BIG big_progress. */
        public big_progress: string;

        /**
         * Creates a new U_SYNC_BIG instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_SYNC_BIG instance
         */
        public static create(properties?: task.IU_SYNC_BIG): task.U_SYNC_BIG;

        /**
         * Encodes the specified U_SYNC_BIG message. Does not implicitly {@link task.U_SYNC_BIG.verify|verify} messages.
         * @param message U_SYNC_BIG message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: task.IU_SYNC_BIG, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_SYNC_BIG message, length delimited. Does not implicitly {@link task.U_SYNC_BIG.verify|verify} messages.
         * @param message U_SYNC_BIG message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: task.IU_SYNC_BIG, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_SYNC_BIG message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_SYNC_BIG
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): task.U_SYNC_BIG;

        /**
         * Decodes a U_SYNC_BIG message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_SYNC_BIG
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): task.U_SYNC_BIG;

        /**
         * Verifies a U_SYNC_BIG message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_RECEIVE. */
    interface IU_RECEIVE {

        /** U_RECEIVE task_id */
        task_id?: (number|null);

        /** U_RECEIVE is_ad */
        is_ad?: (boolean|null);
    }

    /** Represents a U_RECEIVE. */
    class U_RECEIVE implements IU_RECEIVE {

        /**
         * Constructs a new U_RECEIVE.
         * @param [properties] Properties to set
         */
        constructor(properties?: task.IU_RECEIVE);

        /** U_RECEIVE task_id. */
        public task_id: number;

        /** U_RECEIVE is_ad. */
        public is_ad: boolean;

        /**
         * Creates a new U_RECEIVE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_RECEIVE instance
         */
        public static create(properties?: task.IU_RECEIVE): task.U_RECEIVE;

        /**
         * Encodes the specified U_RECEIVE message. Does not implicitly {@link task.U_RECEIVE.verify|verify} messages.
         * @param message U_RECEIVE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: task.IU_RECEIVE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_RECEIVE message, length delimited. Does not implicitly {@link task.U_RECEIVE.verify|verify} messages.
         * @param message U_RECEIVE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: task.IU_RECEIVE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_RECEIVE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_RECEIVE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): task.U_RECEIVE;

        /**
         * Decodes a U_RECEIVE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_RECEIVE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): task.U_RECEIVE;

        /**
         * Verifies a U_RECEIVE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_RECEIVE_STAGE. */
    interface IU_RECEIVE_STAGE {

        /** U_RECEIVE_STAGE stage_index */
        stage_index?: (number|null);
    }

    /** Represents a U_RECEIVE_STAGE. */
    class U_RECEIVE_STAGE implements IU_RECEIVE_STAGE {

        /**
         * Constructs a new U_RECEIVE_STAGE.
         * @param [properties] Properties to set
         */
        constructor(properties?: task.IU_RECEIVE_STAGE);

        /** U_RECEIVE_STAGE stage_index. */
        public stage_index: number;

        /**
         * Creates a new U_RECEIVE_STAGE instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_RECEIVE_STAGE instance
         */
        public static create(properties?: task.IU_RECEIVE_STAGE): task.U_RECEIVE_STAGE;

        /**
         * Encodes the specified U_RECEIVE_STAGE message. Does not implicitly {@link task.U_RECEIVE_STAGE.verify|verify} messages.
         * @param message U_RECEIVE_STAGE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: task.IU_RECEIVE_STAGE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_RECEIVE_STAGE message, length delimited. Does not implicitly {@link task.U_RECEIVE_STAGE.verify|verify} messages.
         * @param message U_RECEIVE_STAGE message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: task.IU_RECEIVE_STAGE, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_RECEIVE_STAGE message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_RECEIVE_STAGE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): task.U_RECEIVE_STAGE;

        /**
         * Decodes a U_RECEIVE_STAGE message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_RECEIVE_STAGE
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): task.U_RECEIVE_STAGE;

        /**
         * Verifies a U_RECEIVE_STAGE message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}

/** Namespace urgenttask. */
declare namespace urgenttask {

    /** Properties of a G_INFO. */
    interface IG_INFO {

        /** G_INFO daily_count */
        daily_count?: (number|null);
    }

    /** Represents a G_INFO. */
    class G_INFO implements IG_INFO {

        /**
         * Constructs a new G_INFO.
         * @param [properties] Properties to set
         */
        constructor(properties?: urgenttask.IG_INFO);

        /** G_INFO daily_count. */
        public daily_count: number;

        /**
         * Creates a new G_INFO instance using the specified properties.
         * @param [properties] Properties to set
         * @returns G_INFO instance
         */
        public static create(properties?: urgenttask.IG_INFO): urgenttask.G_INFO;

        /**
         * Encodes the specified G_INFO message. Does not implicitly {@link urgenttask.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: urgenttask.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified G_INFO message, length delimited. Does not implicitly {@link urgenttask.G_INFO.verify|verify} messages.
         * @param message G_INFO message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: urgenttask.IG_INFO, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a G_INFO message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): urgenttask.G_INFO;

        /**
         * Decodes a G_INFO message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns G_INFO
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): urgenttask.G_INFO;

        /**
         * Verifies a G_INFO message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_DEL_CD. */
    interface IU_DEL_CD {

        /** U_DEL_CD remainder */
        remainder?: (number|null);
    }

    /** Represents a U_DEL_CD. */
    class U_DEL_CD implements IU_DEL_CD {

        /**
         * Constructs a new U_DEL_CD.
         * @param [properties] Properties to set
         */
        constructor(properties?: urgenttask.IU_DEL_CD);

        /** U_DEL_CD remainder. */
        public remainder: number;

        /**
         * Creates a new U_DEL_CD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_DEL_CD instance
         */
        public static create(properties?: urgenttask.IU_DEL_CD): urgenttask.U_DEL_CD;

        /**
         * Encodes the specified U_DEL_CD message. Does not implicitly {@link urgenttask.U_DEL_CD.verify|verify} messages.
         * @param message U_DEL_CD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: urgenttask.IU_DEL_CD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_DEL_CD message, length delimited. Does not implicitly {@link urgenttask.U_DEL_CD.verify|verify} messages.
         * @param message U_DEL_CD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: urgenttask.IU_DEL_CD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_DEL_CD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_DEL_CD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): urgenttask.U_DEL_CD;

        /**
         * Decodes a U_DEL_CD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_DEL_CD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): urgenttask.U_DEL_CD;

        /**
         * Verifies a U_DEL_CD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }

    /** Properties of a U_REWARD. */
    interface IU_REWARD {

        /** U_REWARD task_type */
        task_type?: (number|null);

        /** U_REWARD seq */
        seq?: (number|null);

        /** U_REWARD is_ad */
        is_ad?: (boolean|null);
    }

    /** Represents a U_REWARD. */
    class U_REWARD implements IU_REWARD {

        /**
         * Constructs a new U_REWARD.
         * @param [properties] Properties to set
         */
        constructor(properties?: urgenttask.IU_REWARD);

        /** U_REWARD task_type. */
        public task_type: number;

        /** U_REWARD seq. */
        public seq: number;

        /** U_REWARD is_ad. */
        public is_ad: boolean;

        /**
         * Creates a new U_REWARD instance using the specified properties.
         * @param [properties] Properties to set
         * @returns U_REWARD instance
         */
        public static create(properties?: urgenttask.IU_REWARD): urgenttask.U_REWARD;

        /**
         * Encodes the specified U_REWARD message. Does not implicitly {@link urgenttask.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encode(message: urgenttask.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Encodes the specified U_REWARD message, length delimited. Does not implicitly {@link urgenttask.U_REWARD.verify|verify} messages.
         * @param message U_REWARD message or plain object to encode
         * @param [writer] Writer to encode to
         * @returns Writer
         */
        public static encodeDelimited(message: urgenttask.IU_REWARD, writer?: protobuf.Writer): protobuf.Writer;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer.
         * @param reader Reader or buffer to decode from
         * @param [length] Message length if known beforehand
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decode(reader: (protobuf.Reader|Uint8Array), length?: number): urgenttask.U_REWARD;

        /**
         * Decodes a U_REWARD message from the specified reader or buffer, length delimited.
         * @param reader Reader or buffer to decode from
         * @returns U_REWARD
         * @throws {Error} If the payload is not a reader or valid buffer
         * @throws {protobuf.util.ProtocolError} If required fields are missing
         */
        public static decodeDelimited(reader: (protobuf.Reader|Uint8Array)): urgenttask.U_REWARD;

        /**
         * Verifies a U_REWARD message.
         * @param message Plain object to verify
         * @returns `null` if valid, otherwise the reason why it is not
         */
        public static verify(message: { [k: string]: any }): (string|null);
    }
}
