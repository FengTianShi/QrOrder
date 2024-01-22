import { createRouter, createWebHashHistory } from "vue-router";

import Register from "../views/Register.vue";
import Order from "../views/Order.vue";

const routes = [
  {
    path: "/",
    name: "Register",
    component: Register,
  },
  {
    path: "/order",
    name: "Order",
    component: Order,
  },
];

const router = createRouter({
  history: createWebHashHistory(),
  routes,
});

router.beforeEach(async (to, from) => {
  if (to.name == "Order") {
    //TODO check if customer is registered
    // const isRegistered = false;
    // if (!isRegistered) {
    //   return { name: "Register" };
    // }
  }
});

export default router;
