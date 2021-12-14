import Detail from "./pages/OwnerDetail";
import Owners from "./pages/Owners";

/**
 * Routes Array
 * Same properties should match for all attributes
 */
const routes = [
  {
    path: "/",
    exact: true,
    component: Owners,
  },
  {
    path: "/owners",
    exact: true,
    component: Owners,
  },
  {
    path: "/owner/details/:id",
    exact: true,
    component: Detail,
  },
];
export default routes;
